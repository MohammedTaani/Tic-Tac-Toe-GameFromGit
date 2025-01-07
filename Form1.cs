using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Counter = 0;

        void Stop()
        {

            Counter++;

            if (Counter == 9 && label5.Text == "In Progress")
            {
                MessageBox.Show("Nobady winns , you can play again");
                AllesSchliessen();

            }


        }

        void AllesSchliessen()
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;

            Pen pen = new Pen(white , 10);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 450, 100, 450, 450);
            e.Graphics.DrawLine(pen, 650, 100, 650, 450);
            e.Graphics.DrawLine(pen, 300, 200, 800, 200);

            e.Graphics.DrawLine(pen, 300, 350, 800, 350);




        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        void Colorandern(Button btn, Button btn2, Button btn3) {

            label5.Text = label4.Text;

            btn.BackColor = Color.Green;
            btn2.BackColor = Color.Green;
            btn3.BackColor = Color.Green;



            AllesSchliessen();


        }
        void IsWinn()
        {

            if((button1.Tag.ToString() == "o" && button2.Tag.ToString() == "o" && button3.Tag.ToString() == "o")||(button1.Tag.ToString() == "x" && button2.Tag.ToString() == "x" && button3.Tag.ToString() == "x"))
            {
                Colorandern(button1 , button2, button3);


            }else if((button4.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button6.Tag.ToString() == "o") || (button4.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button6.Tag.ToString() == "x"))
            {

                Colorandern(button4, button5, button6);


            }
            else if((button7.Tag.ToString() == "o" && button8.Tag.ToString() == "o" && button9.Tag.ToString() == "o") || (button7.Tag.ToString() == "x" && button8.Tag.ToString() == "x" && button9.Tag.ToString() == "x"))
            {

                Colorandern(button7, button8, button9);



            }
            else if ((button1.Tag.ToString() == "o" && button6.Tag.ToString() == "o" && button9.Tag.ToString() == "o") || (button1.Tag.ToString() == "x" && button6.Tag.ToString() == "x" && button9.Tag.ToString() == "x"))
            {

                Colorandern(button1, button6, button9);


            }
            else if ((button2.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button8.Tag.ToString() == "o") || (button2.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button8.Tag.ToString() == "x"))
            {

                Colorandern(button2, button5, button8);


            }
            else if ((button3.Tag.ToString() == "o" && button4.Tag.ToString() == "o" && button7.Tag.ToString() == "o") || (button3.Tag.ToString() == "x" && button4.Tag.ToString() == "x" && button7.Tag.ToString() == "x"))
            {

                Colorandern(button3, button4, button7);


            }
            else if ((button1.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button7.Tag.ToString() == "o") || (button1.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button7.Tag.ToString() == "x"))
            {

                Colorandern(button1, button5, button7);


            }
            else if ((button3.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button9.Tag.ToString() == "o") || (button3.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button9.Tag.ToString() == "x"))
            {

                Colorandern(button3, button5, button9);


            }


        }

        private void button_Click(object sender, EventArgs e)
        {

            if (label4.Text == "Player1")
            {
                ((Button)sender).Image = Resources.O;
                ((Button)sender).Tag = "o";

            }
            else
            {

                ((Button)sender).Image = Resources.X;
                ((Button)sender).Tag = "x";
            }

            IsWinn();

            label4_Click(null, null);

            ((Button)sender).Enabled = false;


            Stop();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "Player1")
                label4.Text = "Player2";
            else
                label4.Text = "Player1";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            label4.Text = "Player1";
            label5.Text = "In Progress";

            button1.Image = Resources.question_mark_96;
            button2.Image = Resources.question_mark_96;
            button3.Image = Resources.question_mark_96;
            button4.Image = Resources.question_mark_96;
            button5.Image = Resources.question_mark_96;
            button6.Image = Resources.question_mark_96;
            button7.Image = Resources.question_mark_96;
            button8.Image = Resources.question_mark_96;
            button9.Image = Resources.question_mark_96;


            button1.Tag = "?";
            button2.Tag = "?";
            button3.Tag = "?";
            button4.Tag = "?";
            button5.Tag = "?";
            button6.Tag = "?";
            button7.Tag = "?";
            button8.Tag = "?";
            button9.Tag = "?";


            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;

        }
    }
}
