using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class DiceRolls
    {
        //remove these arrays later//////////////////
        public  Random R = new Random();

        public int[] t3 = { 4, 5, 6, 8, 9, 10 };
        //first dice roll generated
        public static int d1 { get; set; }
        public int Dice1()
        {  
            return d1= R.Next(1, 7);  
        }
        
        //second dice roll generated
        public static int d2 { get; set; }
        public int Dice2()
        {           
            return d2 = R.Next(1, 7);
        }
        //total dice roll
        public int Dicetotal()
        {      
            return d1 += d2 ;
        }
        //continued roll
        public int dt2 { get; set; }
        public int Dicetotal2()
        {
            return dt2= 0;
        }


    }
}
