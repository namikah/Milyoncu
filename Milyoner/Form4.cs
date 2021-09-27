using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Milyoner
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
          
        }
        public int sss=1;
        private void button1_Click(object sender, EventArgs e)
        {
            sss = 9;
            base.Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            sss = 0;
            base.Close();
        }

        
    }
}
