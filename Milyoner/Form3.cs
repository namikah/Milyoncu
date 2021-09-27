using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Milyoner
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            string s;

            sr = File.OpenText("recordlar.txt");
            s = sr.ReadLine();

            while (s != null)
            {
                listBox1.Items.Add(s);
                s = sr.ReadLine();
            }

            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
