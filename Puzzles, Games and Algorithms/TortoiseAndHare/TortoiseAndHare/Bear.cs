using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseAndHare
{
    public class Bear : Runner
    {
        public Bear(int currentPosition, int lane, string name)
        {
            CurrentPosition = currentPosition;
            Lane = lane;
            Name = name;
            RunnerSymbol = "B";

            MoveDescription = $"{Name} is READY! SET! GO!";

            AllRunners.Add(this);
        }

        public override void CalculateMove()
        {
            var move = GetMoveType();

            if (move >= 1 && move <= 50)
            {
                MakeMove(MoveType.BearJump);
                MoveDescription = $"{Name} made a Bear Jump (+5)";
            }
            else if (move >= 51 && move <= 70)
            {
                MakeMove(MoveType.Slip);
                MoveDescription = $"{Name} Slipped  (-6)";
            }
            else
            {
                MakeMove(MoveType.SlowPlod);
                MoveDescription = $"{Name} moved Slow Plod (+1)";
            }
        }
    }
}
