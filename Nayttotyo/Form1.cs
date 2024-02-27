using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nayttotyo
{
    public partial class Form1 : Form
    {
        private const int maxTime = 200;
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(CloseAfterTime);
            thread.Start();
        }

        private void CloseAfterTime()
        {
            int elapsedTime = 0;

            while (true)
            {
                Thread.Sleep(1000); // Odota yksi sekunti

                elapsedTime++;

                if (elapsedTime >= maxTime)
                {
                    CloseForm();
                    break;
                }
            }
        }

        private void CloseForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CloseForm));
            }
            else
            {
                MessageBox.Show("Ohjelma sammuu!");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Valitse ensin resepti");
                return;
            }

            switch (listBox1.SelectedItem.ToString())
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

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Valitse ensin resepti");
                return;
            }

            switch (listBox2.SelectedItem.ToString())
            {
                case "Banaanilettu":
                    Form10 form10 = new Form10();
                    form10.Show();
                    this.Hide();
                    break;

                case "Muffinssi valkosuklaakuorrutteella":
                    Form11 form11 = new Form11();
                    form11.Show();
                    this.Hide();
                    break;

                case "Mokkapala":
                    Form12 form12 = new Form12();
                    form12.Show();
                    this.Hide();
                    break;

                case "Oreojuustokakku":
                    Form13 form13 = new Form13();
                    form13.Show();
                    this.Hide();
                    break;

                case "Porkkanakakku":
                    Form14 form14 = new Form14();
                    form14.Show(); 
                    this.Hide();
                    break;

                case "Suklaakakku":
                    Form15 form15 = new Form15();
                    form15.Show();
                    this.Hide();
                    break;

                case "Tiramisu":
                    Form16 form16 = new Form16();
                    form16.Show();
                    this.Hide();
                    break;

                case "Vadelmavalkosuklaa juustokakku":
                    Form17 form17 = new Form17();
                    form17.Show();
                    this.Hide();
                    break;
            }
        }

        
    }
}