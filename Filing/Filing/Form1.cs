using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Filing
{
    public partial class Form1 : Form
    {
        public Form1()






        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("E:\\");
            comboBox3.Items.Add("C:\\");
            comboBox3.Items.Add("E:\\");

            comboBox6.Items.Add("C:\\");
            comboBox6.Items.Add("E:\\");
            comboBox9.Items.Add("C:\\");
            comboBox9.Items.Add("E:\\");
            comboBox11.Items.Add("C:\\");
            comboBox11.Items.Add("E:\\");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach(DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dpath = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            if (!File.Exists(dpath))
            {
                Directory.CreateDirectory(dpath);
                MessageBox.Show("Folder Created Successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dpath = comboBox3.Text + comboBox4.Text + "\\" + textBox2.Text + "." + textBox3.Text;
            if (!File.Exists(dpath))
            {
                File.Create(dpath);
                MessageBox.Show("File Created");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            {
                comboBox4.Items.Add(di);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox6.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            {
                comboBox5.Items.Add(di);
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox9.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            {
                comboBox8.Items.Add(di);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox6.Text + comboBox5.Text + "\\";
            FileInfo info = new FileInfo(fpath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox7.Items.Add(inf);
            }
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string spath = comboBox6.Text + comboBox5.Text +"\\" + comboBox7.Text;
            string dpath = comboBox9.Text + comboBox8.Text + "\\"+textBox4.Text;

            if (File.Exists(spath))
            {
                File.Copy(spath, dpath);
                MessageBox.Show("File Copied successfully");
            }

            else
            {
                MessageBox.Show("File Does not Exist");

            }
            

           
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox11.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            {
                comboBox10.Items.Add(di);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox11.Text + comboBox10.Text + "\\";
            FileInfo info = new FileInfo(fpath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox12.Items.Add(inf);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fpath=comboBox11.Text+comboBox10.Text+"\\"+comboBox12.Text;
            if (!File.Exists(fpath))
            {
                
                MessageBox.Show("File Not Found");
                
            }

            else
            {
                File.Delete(fpath);
                MessageBox.Show("File Deleted successfully");
            
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = comboBox7.Text;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
