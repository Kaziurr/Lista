using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void dodawanie_danych_Click(object sender, EventArgs e)

        {
            string[] dodaj = { textBox1.Text, textBox3.Text, dateTimePicker1.Text, textBox4.Text };
            var listViewItem = new ListViewItem(dodaj);
            listView1.Items.Add(listViewItem);
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string[] WierszeDoPliku()
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int k = 0; k < item.SubItems.Count; k++)
                    linie[i] += item.SubItems[k].Text + "*";

                i++;
            }
            return linie;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] linie = WierszeDoPliku();
            File.WriteAllLines("filmy.txt", linie);
        }

        /*private void OdczytZPliku()
        {
            if (!File.Exists("filmy.txt"))
                return;
            string[] linie = File.ReadAllLines("filmy.txt");
            foreach(string linia in linie)
            {
                string[] temp = linia.Split('*');
                dodawanie_danych(temp);
            }
        }*/


    }
    }        
