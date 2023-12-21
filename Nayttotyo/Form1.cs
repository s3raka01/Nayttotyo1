using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nayttotyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Valitse ensin resepti");
            }
            string resepti = listBox1.SelectedItem.ToString();

            switch (resepti)
            {
                case "BBQ-hampurilainen":
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    break;

                case "Jauhelihaspagetti":
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                    break;

                case "Kana ja riisi":
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                    break;

                case "Kanakeitto":
                    Form6 form6 = new Form6();
                    form6.Show();
                    this.Hide();
                    break;

                case "Karjalanpaisti":
                    Form7 form7 = new Form7();
                    form7.Show();
                    this.Hide();
                    break;

                case "Lohikeitto":
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                    break;

                case "Pestopasta":
                    Form8 form8 = new Form8();
                    form8.Show();
                    this.Hide();
                    break;

                case "Tonnikalapasta":
                    Form9 form9 = new Form9();
                    form9.Show();
                    this.Hide();
                    break;
            }
           
        }  

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Valitse ensin resepti");
            }

        }
    }
}
