using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
       


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DriveInfo[] dr = DriveInfo.GetDrives();
            foreach (DriveInfo d in dr)
            {
                comboBox1.Items.Add(d);
                comboBox6.Items.Add(d);
               
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            dir.GetDirectories();

            DirectoryInfo[] d = dir.GetDirectories();

            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox6.Text);
            dir.GetDirectories();

            DirectoryInfo[] d = dir.GetDirectories();

            foreach (DirectoryInfo di in d)
            {
                comboBox5.Items.Add(di);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;

            if (File.Exists(fname))
            {
                byte[] b = new byte[1000];

                char[] c = new char[1000];




                FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);

                fs.Read(b, 0, b.Length);
                Decoder d = Encoding.UTF8.GetDecoder();
                d.GetChars(b, 0, b.Length, c, 0, true);

                string s = new string(c);

                textBox1.Text = s;

                fs.Close();

       
            }
            else
            {
                MessageBox.Show("file does not exists");
            }

            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox1.Text + comboBox2.Text + "\\";
            FileInfo fi = new FileInfo(fpath);
            FileInfo[] f = fi.Directory.GetFiles();

            foreach (FileInfo fif in f)
            {
                comboBox3.Items.Add(fif);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = comboBox6.Text + comboBox5.Text + "\\" + textBox3.Text + "." + textBox4.Text;

           
            
                byte[] b = new byte[2000];

                char[] c = new char[2000];



                FileStream fs = new FileStream(fname, FileMode.Append);

                c = textBox2.Text.ToCharArray();

                Encoder en = Encoding.UTF8.GetEncoder();
                en.GetBytes(c, 0, c.Length, b, 0, true);
                fs.Write(b, 0, b.Length);
                fs.Close();
                MessageBox.Show("file has been edited");
           

                comboBox6.Text = "";
                comboBox5.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox2.Text = "";

            

        


                
        }
    }
}
