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
    public partial class frmreklam : Form
    {
        public frmreklam()
        {
            InitializeComponent();
        }
        
        private void frmreklam_Load(object sender, EventArgs e)
        {
            mediaplayer.URL = "milyoncu.mp3";
            base.Width = Screen.PrimaryScreen.Bounds.Width;
            base.Height = Screen.PrimaryScreen.Bounds.Height;
            lblM.Left = base.ClientSize.Width - lblU.Right;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           


            lblI.Left = lblM.Right;
            LblL.Left = lblI.Right;
            lblY.Top = lblM.Top;
            lblO.Left = lblY.Right;
            lblN.Left = lblO.Right;
            lblC.Top = lblM.Top;
            lblU.Left = lblC.Right;



            if (lblM.Left < base.ClientSize.Width/6)
                lblM.Left += 15;
            if (lblI.Top < lblM.Top )
                lblI.Top += 15;
            if (LblL.Top > lblM.Top )
                LblL.Top -= 15;
            if (lblY.Left > LblL.Right )
                lblY.Left -= 15;
            if (lblO.Top < lblM.Top )
                lblO.Top += 15;
            if (lblN.Top > lblM.Top )
                lblN.Top -= 15;
            if (lblC.Left > lblN.Right+3 )
                lblC.Left -= 15;
            if (lblU.Top <lblM.Top )
                lblU.Top += 15;
            if (lblY.Left < LblL.Right+2)
            {
                lblM.Top -= 5;
                lblI.Top -= 5;
                LblL.Top -= 5;
                lblY.Top -= 5;
                lblO.Top -= 5;
                lblN.Top -= 5;
                lblC.Top -= 5;
                lblU.Top -= 5;
            }

            if (lblM.Bottom < 0)
            {
                lbladiniz.Visible = true;
                txtadiniz.Visible = true;
                btgiris.Visible = true;
                timer1.Enabled = false;
            }
           
        }

        private void btgiris_Click(object sender, EventArgs e)
        {
           
            txtadiniz.Visible = false;
            btgiris.Visible = false;
            timer2.Enabled = true;
            if (txtadiniz.Text == "")
            {
                StreamWriter sw;
                sw = File.CreateText("Z.txt");
                sw.WriteLine("  Namiq");
                sw.Close();
                
                
                
                
                
                return;

            } 

                    StreamWriter sr;
                    sr = File.CreateText("Z.txt");
                    sr.WriteLine("  " + txtadiniz.Text.ToString());
                    sr.Close();
                   

                    
                    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            
            pr1.Visible = true;
            ppeleng.Visible = true;
            ppeleng.Left += 4;
            pr1.Value += 1;
            lbladiniz.Text = "Yuklenir  " + pr1.Value + " %";
            lbladiniz.ForeColor = Color.Red;

            if (pr1.Value >98)
            {
                mediaplayer.close();
                timer2.Enabled = false;
                base.Close();
            }
            
        } 
    }
}
