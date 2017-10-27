using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseAndHare
{
    public class Tortoise : Runner
    {
        public Tortoise(int currentPosition, int lane, string name)
        {
            CurrentPosition = currentPosition;
            Lane = lane;
            Name = name;
            RunnerSymbol = "T";

            MoveDescription = $"{Name} is READY! SET! GO!";

            AllRunners.Add(this);
        }

            public override void CalculateMove()
        {
            var move = GetMoveType();
            
            if (move >= 1 && move <= 50)
            {
                MakeMove(MoveType.FastPlod);
                MoveDescription = $"{Name} moved Fast Plod (+3)";
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
