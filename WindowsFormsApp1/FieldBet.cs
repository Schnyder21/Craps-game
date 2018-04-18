using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SideBet : DiceRolls
    {
        //Any seven
        public string AnySeven()
        {
            if ((d1 + d2) == 7)
            {
                return $"{d1 + d2} YOU WIN";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }

        //Double 3
        public string HardWaySix()
        {
            if (d1 == 3 && d2 == 3) { return "Double 3 You WIN!!"; }
            else if ((d1 + d2) == 7)
            {
                return "7 You Loose";
            }
            return "Keep Rolling?";
        }

        //Double 5
        public string HardWayTen()
        {
            if (d1 == 5 && d2 == 5) { return "Double 5 You WIN!!"; }
            else if ((d1 + d2) == 7)
            {
                return "7 You Loose";
            }
            return "Keep Rolling?";
        }

        //Double 2
        public string HardWayFour()
        {
            if (d1 == 2 && d2 == 2) { return "Double 2 You WIN!!"; }
            else if ((d1 + d2) == 7)
            {
                return "7 You Loose";
            }
            return "Keep Rolling?";
        }

        //double 4
        public string HardWayEight()
        {
            if (d1 == 4 && d2 == 4) { return "Double 4 You WIN!!"; }
            else if ((d1 + d2) == 7)
            {
                return "7 You Loose";
            }
            return "Keep Rolling?";
        }

        //Roll a 3
        public string RollThree()
        {
            if ((d1 + d2) == 7)
            {
                return $"3 YOU WIN";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }

        //the 2 bet
        public string RollTwo()
        {
            if ((d1 + d2) == 2)
            {
                return $"2 YOU WIN";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }

        //Roll a 12
        public string RollTwelve()
        {
            if ((d1 + d2) == 12)
            {
                return $"12 YOU WIN";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }

        //Roll an 11
        public string RollEleven()
        {
            if ((d1 + d2) == 11)
            {
                return $"11 YOU WIN";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }

        //Any craps roll
        public string ANYCRAP()
        {
            int[] t = { 2, 3, 12 };
            if (t.Contains(d1 + d2))
            {
                return $"{d1 + d2} YOU WIN";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }
    }
}
