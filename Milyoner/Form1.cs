using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Milyoner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter oledbadapter1;
        OleDbConnection oledbconnection1;
        DataTable dtmain;
        public int q=15;
        private void CreateSqlConnection()
        {
            oledbconnection1 = new OleDbConnection();
            oledbadapter1 = new OleDbDataAdapter();
            dtmain = new DataTable();

            oledbconnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='mybaza.accdb'";
        }          // elaqe yaratmaq

        private void mytimer()
        {
            mediaplayer.URL = "milyoncu.mp3";
            q = 15;
            timer1.Enabled = true;
            listBox2.SelectedIndex = 14;

        }

        private void myrefresh()
        {
            int i;
            try
            {
                DateTime dt = DateTime.Now;
                int l, t, s, m, k, v, hour;
               
                l=listBox2.SelectedIndex;
                if (l > 13) btsualsayi.Text = "Itirilməyən məbləğ: 0 manat";
                if (l == 9) btsualsayi.Text = "Itirilməyən məbləğ: 500 manat";
                if (l == 5) btsualsayi.Text = "Itirilməyən məbləğ: 5000 manat";
                if (l == 0) btsualsayi.Text = "Itirilməyən məbləğ: 100000 manat";

                s = dt.Second;
                m = dt.Minute;
                hour = dt.Hour;
                t = m % 10;
               
                if (t == 0)
                t = m / 10;

                k = s % 10;
                v = 2;
               
                    if (btsualsayi.Text == "Itirilməyən məbləğ:  0 manat")   v = t * 10 + k;
                    if (btsualsayi.Text == "Itirilməyən məbləğ: 500 manat")  v = 100 + t * 10 + k;
                    if (btsualsayi.Text == "Itirilməyən məbləğ: 5000 manat") v = 200 + t * 10 + k;
                   
                for (i = 0; i < listBox1.Items.Count; i++)
                {
                    if (v.ToString() == listBox1.Items[i].ToString() || v==0)
                    {
                        v = v+2;
                       
                     } 
 
                    } 
                
                    listBox1.Items.Add(v);

                    oledbadapter1.SelectCommand = new OleDbCommand();
                    oledbadapter1.SelectCommand.Connection = oledbconnection1;
                    oledbadapter1.SelectCommand.CommandText = "Select * from cedvel1 where colum= " + v;
                    dtmain.Clear();
                    oledbadapter1.Fill(dtmain);
                   
                
                
            }
            catch { };
            string a, b, c, d;

                a = dtmain.Rows[0]["columa"].ToString().Substring(0, dtmain.Rows[0]["columa"].ToString().Length -1);
                b = dtmain.Rows[0]["columb"].ToString().Substring(0, dtmain.Rows[0]["columb"].ToString().Length -1);
                c = dtmain.Rows[0]["columc"].ToString().Substring(0, dtmain.Rows[0]["columc"].ToString().Length -1);
                d = dtmain.Rows[0]["columd"].ToString().Substring(0, dtmain.Rows[0]["columd"].ToString().Length -1);
                
                btsuallar.Text = dtmain.Rows[0]["columsuallar"].ToString();
                bta.Text = a;
                btb.Text = b;
                btc.Text = c;
                btd.Text = d;
            
              
               
        
            
           
        }                    // myrefresh

        private void Form1_Load(object sender, EventArgs e)
        {
            btyari.Visible = false;
            btsuallar.Visible = false;
            bta.Visible = false;
            btb.Visible = false;
            btc.Visible = false;
            btd.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
           frmreklam frmreklam = new frmreklam();
            frmreklam.ShowDialog();
            
           
           
           mediaplayer.URL = "milyoncu.mp3";
            CreateSqlConnection();
            myrefresh();
            
            

            q = 15;
           
            
           timer1.Enabled = true;
           listBox2.SelectedIndex = 14;
            
          StreamReader sr;
         string s;
           
          sr = File.OpenText("Z.txt");
           s = sr.ReadLine().ToString();
           sr.Close();
            
            lblad.Text = "Istirakci:   "+ s;

  
        }

        private void bta_Click(object sender, EventArgs e)
        {
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
            

                if (bta.Text + "*" == dtmain.Rows[0]["columa"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columb"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columc"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                {
                    myrefresh();
                    q = q - 1; listBox2.SelectedIndex = q;

                }
           
                else
                {
                    StreamWriter sr;
                    sr = File.AppendText("recordlar.txt");
                    int i;
                    string s = "";
                    try
                    {
                        for (i = 0; i < listBox2.SelectedItem.ToString().Length; i++)
                            if (listBox2.SelectedItem.ToString().Substring(i, 2) == " -")
                                s = listBox2.SelectedItem.ToString().Substring(0, i);
                    }
                    catch { };
                           
                        
                    sr.WriteLine(lblad.Text.ToString() + "---"+s);
                    sr.Close();
                    base.Close();
                }
            
        }

        private void btb_Click(object sender, EventArgs e)
        {
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
           
                if (btb.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                {
                    myrefresh();
                    q = q - 1; listBox2.SelectedIndex = q;
                    
                }
                else
                {
                    StreamWriter sr;
                    sr = File.AppendText("recordlar.txt");
                    int i;
                    string s = "";
                    try
                    {
                        for (i = 0; i < listBox2.SelectedItem.ToString().Length; i++)
                            if (listBox2.SelectedItem.ToString().Substring(i, 2) == " -")
                                s = listBox2.SelectedItem.ToString().Substring(0, i);
                    }
                    catch { };
                    sr.WriteLine(lblad.Text.ToString() + "---" + s);
                    sr.Close();
                    base.Close();
                }
           
            
        }

        private void btc_Click(object sender, EventArgs e)
        {

            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
                if (btc.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                {
                    myrefresh();
                    q = q - 1; listBox2.SelectedIndex = q;
                   
                }
                else
                {
                    StreamWriter sr;
                    sr = File.AppendText("recordlar.txt");
                    int i;
                    string s = "";
                    try
                    {
                        for (i = 0; i < listBox2.SelectedItem.ToString().Length; i++)
                            if (listBox2.SelectedItem.ToString().Substring(i, 2) == " -")
                                s = listBox2.SelectedItem.ToString().Substring(0, i);
                    }
                    catch { };
                    sr.WriteLine(lblad.Text.ToString() + "---" + s);
                    sr.Close();
                    base.Close();
                }
            
        }

        private void btd_Click(object sender, EventArgs e)
        {
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
           
                if (btd.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                {
                    myrefresh();
                    q = q - 1; listBox2.SelectedIndex = q;
                  
                }
                else
                {
                    StreamWriter sr;
                    sr = File.AppendText("recordlar.txt");
                    int i;
                    string s = "";
                    try
                    {
                        for (i = 0; i < listBox2.SelectedItem.ToString().Length; i++)
                            if (listBox2.SelectedItem.ToString().Substring(i, 2) == " -")
                                s = listBox2.SelectedItem.ToString().Substring(0, i);
                    }
                    catch { };
                    sr.WriteLine(lblad.Text.ToString() + "---" + s);
                    sr.Close();
                    base.Close();
                }
           
        }
        
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0 && timer1.Enabled == false && timer2.Enabled == false)
            {
                btyari.Visible = false;
                btsuallar.Visible = false;
                bta.Visible = false;
                btb.Visible = false;
                btc.Visible = false;
                btd.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                StreamWriter sr;
                sr = File.AppendText("recordlar.txt");
              
                sr.WriteLine(lblad.Text.Substring(13, lblad.Text.Length - 13).ToString() + "            100.000  Manat");
                sr.Close();
                
                Form4 form4 = new Form4();
                form4.lbmelumat.Text = lblad.Text.Substring(13,lblad.Text.Length-13) + "  Bey,  siz  " + "100.000  Manat";
                form4.lbmelumat2.Text = "qazanaraq  oyunu  terk  etdiniz...Tebrikler...";
                form4.ShowDialog();

                q = 15;
                myrefresh();
                timer1.Enabled = true;
                listBox2.SelectedIndex = 14;
                
                
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            mediaplayer.close();
            mediaplayer.URL = "milyoncu.mp3";
            q = 15;
            listBox2.SelectedIndex = 14;
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            btyari.Visible = false;
            btsuallar.Visible = false;
            bta.Visible = false;
            btb.Visible = false;
            btc.Visible = false;
            btd.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

           
                
                listBox2.SelectedIndex -= 1;
          
            if (listBox2.SelectedIndex == 0)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            try
            {
                listBox2.SelectedIndex += 1;
            }
            catch { };
            if (listBox2.SelectedIndex == 14)
            {
                btyari.Visible = true;
                btyari.Text = "50/50";
                btsuallar.Visible = true; ;
                bta.Visible = true;
                btb.Visible = true;
                btc.Visible = true;
                btd.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true; 
                mediaplayer.close();
                myrefresh();
                timer2.Enabled = false;
               



                
            }
        }

        private void neticelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            if (btyari.Text=="X")
            {
                return;
            }
            bta.Visible = false;
            btb.Visible = false;
            btc.Visible = false;
            btd.Visible = false;


            if (bta.Text + "*" == dtmain.Rows[0]["columa"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columb"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columc"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                bta.Visible = true;
            if (btb.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                btb.Visible = true;
            if (btc.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                btc.Visible = true;
            if (btd.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columd"].ToString())
                btd.Visible = true;
            if (bta.Text + "1" == dtmain.Rows[0]["columa"].ToString() || bta.Text + "1" == dtmain.Rows[0]["columb"].ToString() || bta.Text + "1" == dtmain.Rows[0]["columc"].ToString() || bta.Text + "1" == dtmain.Rows[0]["columd"].ToString())
                bta.Visible = true;
            if (btb.Text + "1" == dtmain.Rows[0]["columa"].ToString() || btb.Text + "1" == dtmain.Rows[0]["columb"].ToString() || btb.Text + "1" == dtmain.Rows[0]["columc"].ToString() || btb.Text + "1" == dtmain.Rows[0]["columd"].ToString())
                btb.Visible = true;
            if (btc.Text + "1" == dtmain.Rows[0]["columa"].ToString() || btc.Text + "1" == dtmain.Rows[0]["columb"].ToString() || btc.Text + "1" == dtmain.Rows[0]["columc"].ToString() || btc.Text + "1" == dtmain.Rows[0]["columd"].ToString())
                btc.Visible = true;
            if (btd.Text + "1" == dtmain.Rows[0]["columa"].ToString() || btd.Text + "1" == dtmain.Rows[0]["columb"].ToString() || btd.Text + "1" == dtmain.Rows[0]["columc"].ToString() || btd.Text + "1" == dtmain.Rows[0]["columd"].ToString())
                btd.Visible = true;
            label1.Visible = bta.Visible;
            label2.Visible = btb.Visible;
            label3.Visible = btc.Visible;
            label4.Visible = btd.Visible;

            btyari.Text = "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.sss = 1;
            
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            

            if (bta.Text + "*" == dtmain.Rows[0]["columa"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columb"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columc"].ToString() || bta.Text + "*" == dtmain.Rows[0]["columd"].ToString())
            {
                mediaplayer.URL = "alqis.wma";
                myrefresh();
                q = q - 1; listBox2.SelectedIndex = q;

            }

            else
            {
                
                StreamWriter sr;
                sr = File.AppendText("recordlar.txt");
                string v="";
               
                if (listBox2.SelectedIndex == 0) v = "100.000  Manat";
                if (listBox2.SelectedIndex <= 4 && listBox2.SelectedIndex > 0) v = "5.000  Manat";
                if (listBox2.SelectedIndex <= 8 && listBox2.SelectedIndex > 4) v = "500  Manat";
                if (listBox2.SelectedIndex > 8) v = "0  Manat";
                sr.WriteLine(lblad.Text.Substring(13, lblad.Text.Length - 13).ToString() + "            " + v);
                sr.Close();
            
                form4.ShowDialog();
                form4.lbmelumat.Text = lblad.Text.Substring(13, lblad.Text.Length - 13) + "  Bey,  siz   " + v;
                form4.lbmelumat2.Text = "qazanaraq  oyunu  terk  etdiniz...Tebrikler...";
                if (form4.sss == 0) base.Close();
                mytimer();
               
                
                
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.sss = 1;
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
           
            if (btb.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btb.Text + "*" == dtmain.Rows[0]["columd"].ToString())
            {
                mediaplayer.URL = "alqis.wma";
                myrefresh();
                q = q - 1; listBox2.SelectedIndex = q;

            }
            else
            {

                StreamWriter sr;
                sr = File.AppendText("recordlar.txt");
                string v = "";

                if (listBox2.SelectedIndex == 0) v = "100.000  Manat";
                if (listBox2.SelectedIndex <= 4 && listBox2.SelectedIndex > 0) v = "5.000  Manat";
                if (listBox2.SelectedIndex <= 8 && listBox2.SelectedIndex > 4) v = "500  Manat";
                if (listBox2.SelectedIndex > 8) v = "0  Manat";

                sr.WriteLine(lblad.Text.Substring(13, lblad.Text.Length - 13).ToString() + "            " + v);
   
                form4.lbmelumat.Text = lblad.Text.Substring(13, lblad.Text.Length-13) + "  Bey,  siz   " + v;
                form4.lbmelumat2.Text = "qazanaraq  oyunu  terk  etdiniz...Tebrikler...";
                form4.ShowDialog();
                sr.Close();
                if (form4.sss == 0) base.Close();
                mytimer();
               
                
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.sss = 1;
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
           
            if (btc.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btc.Text + "*" == dtmain.Rows[0]["columd"].ToString())
            {
                mediaplayer.URL = "alqis.wma";
                myrefresh();
                q = q - 1; listBox2.SelectedIndex = q;

            }
                
            else
            {

                StreamWriter sr;
                sr = File.AppendText("recordlar.txt");
                string v = "";

                if (listBox2.SelectedIndex == 0) v = "100.000  Manat";
                if (listBox2.SelectedIndex <= 4 && listBox2.SelectedIndex > 0) v = "5.000  Manat";
                if (listBox2.SelectedIndex <= 8 && listBox2.SelectedIndex > 4) v = "500  Manat";
                if (listBox2.SelectedIndex > 8) v = "0  Manat";
                sr.WriteLine(lblad.Text.Substring(13, lblad.Text.Length - 13).ToString() + "            " + v);

              
                form4.lbmelumat.Text = lblad.Text.Substring(13, lblad.Text.Length - 13) + "  Bey,  siz   " + v;
                form4.lbmelumat2.Text = "qazanaraq  oyunu  terk  etdiniz...Tebrikler...";
                form4.ShowDialog();
                sr.Close();
                if (form4.sss == 0) base.Close();
                mytimer();
               
            }
                 
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.sss = 1;
            bta.Visible = true;
            btb.Visible = true;
            btc.Visible = true;
            btd.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
           

            if (btd.Text + "*" == dtmain.Rows[0]["columa"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columb"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columc"].ToString() || btd.Text + "*" == dtmain.Rows[0]["columd"].ToString())
            {
                mediaplayer.URL = "alqis.wma";
                myrefresh();
                q = q - 1; listBox2.SelectedIndex = q;

            
           }
                
            else
            {

                StreamWriter sr;
                sr = File.AppendText("recordlar.txt");
                string v = "";

                if (listBox2.SelectedIndex == 0) v = "100.000  Manat";
                if (listBox2.SelectedIndex <= 4 && listBox2.SelectedIndex > 0) v = "5.000  Manat";
                if (listBox2.SelectedIndex <= 8 && listBox2.SelectedIndex > 4) v = "500  Manat";
                if (listBox2.SelectedIndex > 8) v = "0  Manat";
                sr.WriteLine(lblad.Text.Substring(13, lblad.Text.Length - 13).ToString() + "            " + v);

              
                form4.lbmelumat.Text = lblad.Text.Substring(13, lblad.Text.Length - 13) + "  Bey,  siz   " + v;
                form4.lbmelumat2.Text = "qazanaraq  oyunu  terk  etdiniz...Tebrikler...";
                form4.ShowDialog();
                sr.Close();
                if (form4.sss == 0) base.Close();
                mytimer();
             
            }
                 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoyaQayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediaplayer.close();
            btyari.Visible = false;
            btsuallar.Visible = false;
            bta.Visible = false;
            btb.Visible = false;
            btc.Visible = false;
            btd.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            frmreklam frmreklam = new frmreklam();
            frmreklam.ShowDialog();
            

            CreateSqlConnection();

            q = 15;
            myrefresh();
            timer1.Enabled = true;
            listBox2.SelectedIndex = 14;


            StreamReader sr;
            string s;

            sr = File.OpenText("Z.txt");
            s = sr.ReadLine().ToString();

            lblad.Text = s;
            mediaplayer.URL = "milyoncu.mp3";
        }
       
        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int k, s, m, hour;
            k=dt.Second;
            s = dt.Second;
            m = dt.Minute;
            hour = dt.Hour;
            btvaxt.Text = "Hazirki vaxt:    " + hour + ". " + m + ". " + s;


          
        }

        private void sesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mediaplayer.Visible == false)
            {
                mediaplayer.Visible = true;
                return;
            }
            if (mediaplayer.Visible == true)
            {
                mediaplayer.Visible = false;

            }
        }

        private void btsualsayi_Click(object sender, EventArgs e)
        {

        }

        private void mediaplayer_Enter(object sender, EventArgs e)
        {

        }

        

        

       
        
        
        

        

        

       
        
       

        

        

       

       

       

       

            

            //   sual cavablarin oxunmasi......



        
    }
}
