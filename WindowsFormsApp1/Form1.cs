using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DiceRolls dr = new DiceRolls();
        private void button1_Click(object sender, EventArgs e)
        {
            Text1.Text= (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //first button
        private void button2_Click(object sender, EventArgs e)
        {
            WinLoose WL = new WinLoose();

            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text =  WL.Winnings();
            //Text3.Text = WL.Yoursecondroll();


        }

        //field button
        private void button3_Click(object sender, EventArgs e)
        {
            WinLoose WL = new WinLoose();
            

            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = WL.WinningField();
        }

        //any seven button
        SideBet SB = new SideBet();
        private void button4_Click(object sender, EventArgs e)
        {
           

            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.AnySeven();
        }
        //double 3 roll
        private void button5_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.HardWaySix();
        }
        //double 5 roll
        private void button6_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.HardWayTen();
        }
        //double 4 roll
        private void button7_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.HardWayEight();
        }
        //Double 2 roll
        private void button8_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.HardWayFour();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.RollThree();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.RollTwo();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.RollTwelve();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.RollEleven();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Text1.Text = (Convert.ToString(dr.Dice1()));
            Text2.Text = (Convert.ToString(dr.Dice2()));
            Text3.Text = SB.ANYCRAP();
        }
    }
}
