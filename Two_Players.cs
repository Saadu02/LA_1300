using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Two_Players : Form
    {
        public int spieler = 0;
        public int zug = 0; 
        public int s1 = 0;  
        public int s2 = 0;
        public int sd = 0;

        bool IsDraw()
        {
            if ((zug == 9) && (IsWinner() == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IsWinner()
        {
            //horizontal
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            //vertikal
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            //diagonal
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;
        }

        public Two_Players()
        {
            InitializeComponent();
        }

        private void Two_Players_Load(object sender, EventArgs e)
        {
            Ibl_x.Text = "X: " + s1;
            Ibl_y.Text = "Y: " + s1;
            Ibl_draw.Text = "Draw: " + s1;
        }

        private void ButtonsClick(Object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (spieler % 2 == 0)
                {
                    button.Text = "X";
                    spieler++;
                    zug++;
                }
                else
                {
                    button.Text = "O";
                    spieler++;
                    zug++;
                }
                if (IsDraw() == true)
                {
                    MessageBox.Show("Draw");
                    sd++;
                    NewGame();
                }

                if (IsWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show(textBox1.Text + " hat gewonnen");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show(textBox2.Text + " hat gewonnen");
                        s2++;
                        NewGame();
                    }
                }
            }

        }
        private void Btn_NG_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        public void NewGame()
        {
            spieler = 2;
            zug = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";  //alle Button sind 0

            Ibl_x.Text = "X: " + s1;
            Ibl_y.Text = "Y: " + s2;        //labels zurück setzten
            Ibl_draw.Text = "Draw: " + sd;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 hilfe = new Form1();
            hilfe.ShowDialog();
        }
    }
}
