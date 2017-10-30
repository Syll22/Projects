using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseAndHare
{
    public class Track
    {
        public const int TrackLength = 45;
        public const int NumOfRunners = 3;

        public string[,] Tracks { get; set; }

        public Track()
        {
            Tracks = new string[TrackLength + 1, NumOfRunners];
        }

        public void DisplayRaceTrack()
        {
            Console.WriteLine();
            for (int i = 0; i <= TrackLength; i++)
            {
                Console.Write(i + "  | ");
                for (int c = 0; c < NumOfRunners; c++)
                {
                    if (Tracks[i,c] == null)
                    {
                        Console.Write("  | ");
                    }
                    else
                        Console.Write(Tracks[i,c] + " | ");
                }
                Console.WriteLine();
            }
        }

        public void RunnerPosition(Runner runner)
        {
            Tracks[runner.OrigPosition, runner.Lane] = null;
            Tracks[runner.CurrentPosition, runner.Lane] = runner.RunnerSymbol;
        }
    }
}
