using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIConnectFour
{
    public partial class Form1 : Form
    {
        BoardChecker bc = new BoardChecker();
        public bool hold = true;
        public Button[] buttons;
        public int change = 0;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12,
            button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26,
            button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39,
            button40, button41, button42 };
            //bc.Clear();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (hold)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo, button.Width, button.Height);
                change = button.TabIndex;
                Button buttontest = buttons[change];
                while (change + 7 < 42 && buttontest.Image == null)
                {
                    change += 7;
                    buttontest = buttons[change];
                }
                if (buttontest.Image != null)
                    change -= 7;
                Button buttonoof = buttons[change];
                hold = false;
                if (buttonoof.Image == null)
                {
                    buttonoof.Image = bmp;
                    bc.Accumulate(change, "X");
                    buttonoof.Update();
                    textBox1.Text = "O";
                }
                if (bc.Winner(change))
                {
                    textBox2.Text = "X Wins!";
                    label1.Text = "Result: " + Environment.NewLine + "X Winning: " + Math.Round(bc.xAvg, 2) + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
                }
            }

            else if (!hold)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cat, button.Width, button.Height);
                change = button.TabIndex;
                Button buttontest = buttons[change];
                while (change + 7 < 42 && buttontest.Image == null)
                {
                    change += 7;
                    buttontest = buttons[change];
                }
                if (buttontest.Image != null)
                    change -= 7;
                Button buttonoof = buttons[change];
                hold = true;
                if (buttonoof.Image == null)
                {
                    buttonoof.Image = bmp;
                    bc.Accumulate(change, "O");
                    buttonoof.Update();
                    textBox1.Text = "X";
                }
                if (bc.Winner(change))
                {
                    textBox2.Text = "O Wins!";
                    label1.Text = "Result: " + Environment.NewLine + "X Winning: " + Math.Round(bc.xAvg, 2) + Environment.NewLine + "O Winning: " + Math.Round(bc.oAvg, 2);
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button11.Image = null;
            button12.Image = null;
            button13.Image = null;
            button14.Image = null;
            button15.Image = null;
            button16.Image = null;
            button17.Image = null;
            button18.Image = null;
            button19.Image = null;
            button20.Image = null;
            button21.Image = null;
            button23.Image = null;
            button24.Image = null;
            button25.Image = null;
            button26.Image = null;
            button27.Image = null;
            button28.Image = null;
            button29.Image = null;
            button30.Image = null;
            button31.Image = null;
            button32.Image = null;
            button33.Image = null;
            button34.Image = null;
            button35.Image = null;
            button36.Image = null;
            button37.Image = null;
            button38.Image = null;
            button39.Image = null;
            button40.Image = null;
            button41.Image = null;
            button42.Image = null;
            textBox1.Text = "X";
            textBox2.Text = "";
            label1.Text = "Records:";
            bc.numGames = 0;
            bc.oAvg = 0;
            bc.oWins = 0;
            bc.xAvg = 0;
            bc.xWins = 0;
            hold = true;
            bc.Clear();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button11.Image = null;
            button12.Image = null;
            button13.Image = null;
            button14.Image = null;
            button15.Image = null;
            button16.Image = null;
            button17.Image = null;
            button18.Image = null;
            button19.Image = null;
            button20.Image = null;
            button21.Image = null;
            button23.Image = null;
            button24.Image = null;
            button25.Image = null;
            button26.Image = null;
            button27.Image = null;
            button28.Image = null;
            button29.Image = null;
            button30.Image = null;
            button31.Image = null;
            button32.Image = null;
            button33.Image = null;
            button34.Image = null;
            button35.Image = null;
            button36.Image = null;
            button37.Image = null;
            button38.Image = null;
            button39.Image = null;
            button40.Image = null;
            button41.Image = null;
            button42.Image = null;
            textBox1.Text = "";
            textBox2.Text = "";
            bc.Clear();
        }
    }
}
