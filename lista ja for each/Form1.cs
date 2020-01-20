using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lista_ja_for_each
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        // declararation of list and so on
        private List<string> listaa;
        private string z;

        private void button1_Click(object sender, EventArgs e)
        {
            // makes the list.
            listaa = new List<string>();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //adding the string to list.
            string x = textBox2.Text;
            listaa.Add(x);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //combobox string.
            z = comboBox1.Text;

            //checking if user wants to see the whole list or spesific parts.
            if (string.IsNullOrEmpty(z))
            {


                foreach (string o in listaa)
                {

                    comboBox1.DataSource = listaa;
                }
            }
            else
            {
                foreach (string item in listaa)
                {
                    if (item.Contains(z))
                    {
                        //ok i tought that i needed to do this function but apparently i dont so this part is unfinished.
                    }
                }
            }

        }
    }
}
