using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vysledek=0;
        bool soucet = false;
        bool odecet = false;
        bool nasobeni = false;
        bool deleni = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void pridat0_MouseEnter(object sender, EventArgs e)
        {
            pridat0.BackColor = Color.Black;
        }

        private void pridat0_MouseLeave(object sender, EventArgs e)
        {
            pridat0.BackColor = Color.Gray;
        }

        private void pridat1_MouseEnter(object sender, EventArgs e)
        {
            pridat1.BackColor = Color.Black;
        }

        private void pridat1_MouseLeave(object sender, EventArgs e)
        {
            pridat1.BackColor = Color.Gray;
        }

        private void pridat2_MouseEnter(object sender, EventArgs e)
        {
            pridat2.BackColor = Color.Black;
        }

        private void pridat2_MouseLeave(object sender, EventArgs e)
        {
            pridat2.BackColor = Color.Gray;
        }

        private void pridat3_MouseEnter(object sender, EventArgs e)
        {
            pridat3.BackColor = Color.Black;
        }

        private void pridat3_MouseLeave(object sender, EventArgs e)
        {
            pridat3.BackColor = Color.Gray;
        }

        private void pridat4_MouseEnter(object sender, EventArgs e)
        {
            pridat4.BackColor = Color.Black;
        }

        private void pridat4_MouseLeave(object sender, EventArgs e)
        {
            pridat4.BackColor = Color.Gray;
        }

        private void pridat5_MouseEnter(object sender, EventArgs e)
        {
            pridat5.BackColor = Color.Black;
        }

        private void pridat5_MouseLeave(object sender, EventArgs e)
        {
            pridat5.BackColor = Color.Gray;
        }

        private void pridat6_MouseEnter(object sender, EventArgs e)
        {
            pridat6.BackColor = Color.Black;
        }

        private void pridat6_MouseLeave(object sender, EventArgs e)
        {
            pridat6.BackColor = Color.Gray;
        }

        private void pridat7_MouseEnter(object sender, EventArgs e)
        {
            pridat7.BackColor = Color.Black;
        }

        private void pridat7_MouseLeave(object sender, EventArgs e)
        {
            pridat7.BackColor = Color.Gray;
        }

        private void pridat8_MouseEnter(object sender, EventArgs e)
        {
            pridat8.BackColor = Color.Black;
        }

        private void pridat8_MouseLeave(object sender, EventArgs e)
        {
            pridat8.BackColor = Color.Gray;
        }

        private void pridat9_MouseEnter(object sender, EventArgs e)
        {
            pridat9.BackColor = Color.Black;
        }

        private void pridat9_MouseLeave(object sender, EventArgs e)
        {
            pridat9.BackColor = Color.Gray;
        }

        private void delete10_MouseEnter(object sender, EventArgs e)
        {
            delete10.BackColor = Color.Black;
        }

        private void delete10_MouseLeave(object sender, EventArgs e)
        {
            delete10.BackColor = Color.Gray;
        }

        private void deleno_MouseEnter(object sender, EventArgs e)
        {
            deleno.BackColor = Color.Black;
        }

        private void deleno_MouseLeave(object sender, EventArgs e)
        {
            deleno.BackColor = Color.Gray;
        }

        private void krat_MouseEnter(object sender, EventArgs e)
        {
            krat.BackColor = Color.Black;
        }

        private void krat_MouseLeave(object sender, EventArgs e)
        {
            krat.BackColor = Color.Gray;
        }

        private void minus_MouseEnter(object sender, EventArgs e)
        {
            minus.BackColor = Color.Black;
        }

        private void minus_MouseLeave(object sender, EventArgs e)
        {
            minus.BackColor = Color.Gray;
        }

        private void rovnase_MouseEnter(object sender, EventArgs e)
        {
            rovnase.BackColor = Color.Black;
        }

        private void rovnase_MouseLeave(object sender, EventArgs e)
        {
            rovnase.BackColor = Color.Gray;
        }

        private void plus_MouseEnter(object sender, EventArgs e)
        {
            plus.BackColor = Color.Black;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.BackColor = Color.Gray;
        }

        private void carka_MouseEnter(object sender, EventArgs e)
        {
            carka.BackColor = Color.Black;
        }

        private void carka_MouseLeave(object sender, EventArgs e)
        {
            carka.BackColor = Color.Gray;
        }

        private void pridat0_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("0");
        }

        private void pridat1_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("1");
        }

        private void pridat2_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("2");
            
        }

        private void pridat3_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("3");
        }

        private void pridat4_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("4");
        }

        private void pridat5_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("5");
        }

        private void pridat6_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("6");
        }

        private void pridat7_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("7");
        }

        private void pridat8_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("8");
        }

        private void pridat9_Click(object sender, EventArgs e)
        {
            textbox1.AppendText("9");
        }

        private void carka_Click(object sender, EventArgs e)
        {
            textbox1.AppendText(",");
        }

        private void plus_Click(object sender, EventArgs e)
        {
            vysledek = vysledek + Convert.ToDouble(textbox1.Text);
            soucet = true;
            textbox1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            vysledek = vysledek - Convert.ToDouble(textbox1.Text);
            odecet = true;
            textbox1.Clear();
        }

        private void krat_Click(object sender, EventArgs e)
        {
            vysledek = vysledek * Convert.ToDouble(textbox1.Text);
            nasobeni = true;
            textbox1.Clear();
        }

        private void deleno_Click(object sender, EventArgs e)
        {
            int cislo1;
            cislo1 = Convert.ToInt32(textbox1.Text);
            deleni = true;
            if (cislo1 == 0)
            {
                MessageBox.Show("Nelze dělit nulou!");
            }
            else
            {
                vysledek = vysledek / Convert.ToDouble(textbox1.Text);
            }
            textbox1.Clear();
        }

        private void delete10_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
        }

        private void rovnase_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textbox1.Text);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            if(soucet == true)
            {
                vysledek = vysledek + Convert.ToDouble(textbox1.Text);
            } 
            if(odecet == true)
            {
                vysledek = vysledek - Convert.ToDouble(textbox1.Text);
            }
            if(nasobeni==true)
            {
                vysledek = vysledek * Convert.ToDouble(textbox1.Text);
            }
            if(deleni == true)
            {
                vysledek = vysledek / Convert.ToDouble(textbox1.Text);
            }
            textbox1.Text = Convert.ToString(vysledek);
        }
    }
}
