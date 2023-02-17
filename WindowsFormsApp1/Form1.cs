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
        public string[] array;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            array = new string[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inserimento(ref array, textBox1.Text, ref dim);

            listView1.Clear();
            textBox1.Clear();

            for(int i = 0; i < dim; i++)
            {
                
                listView1.Items.Add(array[i]);
            }
            textBox1.Focus();
        }
        private static void Cancellazione(ref string[] array, string parola)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == parola)
                {
                    int b = i;
                    while (b < array.Length - 1)
                    {
                        array[b] = array[b + 1];
                        b++;

                    }
                }
            }
        }
        private static void ModificaNome(ref string[] array, string parola, string parolaGiusta)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(parola))
                {
                    array[i] = parolaGiusta;
                    break;
                }
            }
        }
        private static void Inserimento(ref string[] array, string parola, ref int posizione)
        {
            array[posizione] = parola;
            posizione++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancellazione(ref array, textBox1.Text);
            listView1.Clear();
            textBox1.Clear();
            for (int i = 0; i < dim; i++)
            {

                listView1.Items.Add(array[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificaNome(ref array, textBox1.Text, textBox2.Text);
            
            listView1.Clear();
            textBox1.Clear();
            for (int i = 0; i < dim; i++)
            {

                listView1.Items.Add(array[i]);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                textBox2.Visible = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
