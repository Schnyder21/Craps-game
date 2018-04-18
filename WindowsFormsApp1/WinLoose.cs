using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class WinLoose: DiceRolls
    {

        //Come out roll
        public string Winnings()
        {
                
            //creat statment that will allow you to compare win vs loss with dice total
            switch (Dicetotal())
            {
                case 7: return "7 WINNER!!";
                case 11: return "11 WINNER!!";
                case 2: return "SNAKE EYES";
                case 3: return "3 TREYS";
                case 12: return "12 BOX CAR";
                case 4: return "4 Roll Again";
                case 5: return "5 Roll Again";
                case 6: return "6 Roll Again";
                case 8: return "8 Roll Again";
                case 9: return "9 Roll Again";
                case 10: return "10 Roll Again";
                   
            }
           
            return "default";
        }
        //The field
        public string WinningField()
        {
            switch (d1 + d2)
            {
                case 3: return "3 YOU WIN 1 TO 1";
                case 4: return "4 YOU WIN 1 TO 1";
                case 9: return "9 YOU WIN 1 TO 1";
                case 10: return " 10 YOU WIN 1 TO 1";
                case 11: return "11 YOU WIN 1 TO 1";
                case 2: return "2 YOU WIN 2 TO 1";
                case 12: return $"12 YOU WIN 2 to 1";

            }
            return $"{d1 + d2} SORRY YOU LOOSE";
        }



    }
}

