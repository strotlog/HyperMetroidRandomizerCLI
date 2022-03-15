using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandLine; // from NuGet

using SuperMetroidRandomizer.Random;

namespace SuperMetroidRandomizer
{
    static class Program
    {
        public class Options
        {
            [Option('s', "seed", Required = false, Default = 0, HelpText = "Seed number to produce the same randomization as someone else using the same copy of this program (0 or unset -> random seed)")]
            public int seed { get; set; }

            [Option('d', "difficulty", Required = true, HelpText = "Difficulty: Casual, Veteran, Masochist, or Max")]
            public string difficulty { get; set; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Main2)
                .WithNotParsed(HandleParserError);
        }

        public static void HandleParserError(IEnumerable<Error> errs)
        {
            Environment.Exit(1);
        }

        static public void Main2(Options cli)
        {
            string difficultyStr = cli.difficulty;
            difficultyStr = difficultyStr.ToLower();
            if (difficultyStr.Length > 0 ) {
                difficultyStr = char.ToUpper(difficultyStr[0]) + difficultyStr.Substring(1);
            }
            RandomizerDifficulty difficulty;
            switch (difficultyStr) {
                case "Casual":
                    difficulty = RandomizerDifficulty.Casual;
                    break;
                case "Veteran":
                    difficulty = RandomizerDifficulty.Speedrunner;
                    break;
                case "Masochist":
                    difficulty = RandomizerDifficulty.Masochist;
                    break;
                case "Max":
                    difficulty = RandomizerDifficulty.Max;
                    break;
                default:
                    Console.WriteLine("--difficulty <Casual, Veteran, Masochist, Max> is required");
                    return;
            }

            int seed;
            if (cli.seed == 0) {
                seed = (new SeedRandom()).Next(10 * 1000 * 1000); // 10 million possible random seeds.
            } else {
                seed = cli.seed;
            }
            string romname = string.Format("Hyper Metroid {0}{1:0000000}.sfc",
                                           (difficulty == RandomizerDifficulty.Max ? 'X' : difficultyStr[0]),
                                           seed);

            var romLocations = SuperMetroidRandomizer.Rom.RomLocationsFactory.GetRomLocations(difficulty);
            var randomizerV11 = new RandomizerV11(seed, romLocations, null);
            string ret = randomizerV11.CreateRom(romname);

            if (ret == "OK")
            {
                Console.WriteLine("Wrote: {0}", romname);
            } else {
                // ret should contain an error
                Console.WriteLine("(Version {0})", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
                Console.WriteLine(ret);
                Environment.Exit(1);
            }
        }
    }
}
