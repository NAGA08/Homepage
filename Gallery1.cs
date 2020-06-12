using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Gallery1 : Form
    {
        public Gallery1()
        {
            InitializeComponent();
        }

        private void Gallery1_Load(object sender, EventArgs e)
        {
            glrpctr.Image = Properties.Resources._1;
            glrpctr.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer tm = new Timer();
            tm.Interval = 200;
            tm.Tick += new EventHandler(glrpctr_Click);
            tm.Start();

        }
        

        private void glrpctr_Click(object sender, EventArgs e)
        {
           List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._1);
            b1.Add(Properties.Resources._2);
            b1.Add(Properties.Resources._3);
            b1.Add(Properties.Resources._4);
            b1.Add(Properties.Resources._5);
            b1.Add(Properties.Resources._6);
            b1.Add(Properties.Resources._7);
            b1.Add(Properties.Resources._8);
            b1.Add(Properties.Resources._9);
            b1.Add(Properties.Resources._10);
            b1.Add(Properties.Resources._12);
            b1.Add(Properties.Resources._13);
            b1.Add(Properties.Resources._14);
            b1.Add(Properties.Resources._15);
            b1.Add(Properties.Resources._16);
            b1.Add(Properties.Resources._17);
            b1.Add(Properties.Resources._18);
            b1.Add(Properties.Resources._19);
            b1.Add(Properties.Resources._20);
            b1.Add(Properties.Resources._21);
            b1.Add(Properties.Resources._22);
            b1.Add(Properties.Resources._23);
            b1.Add(Properties.Resources._24);
            int index = DateTime.Now.Second % b1.Count;
            glrpctr.Image = b1[index];

        }

        private void glrhmebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void glrext_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}

    