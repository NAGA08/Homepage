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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 14)
            {
                imageNumber = 1;
            }
            slidepic.ImageLocation = string.Format(@"Images\{0}.jpg",imageNumber);
            imageNumber++;
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }


        //dashboard
        private void dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //title label
        private void title_txt_Click(object sender, EventArgs e)
        {

        }
        //logo picturebox
        private void logo_Click(object sender, EventArgs e)
        {

        }
        //cms label
        private void cms_txt_Click(object sender, EventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //home button
        private void hmbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 h = new Form1();
            h.Show();
        }
        //Register button
        private void rgtbtn_Click(object sender, EventArgs e)
        {

        }

        //login button
        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        //gallery button
        private void glrbtn_Click(object sender, EventArgs e)
        {
            
            Gallery1 g = new Gallery1();
            g.ShowDialog();
            this.Hide();
        }
        //about button
        private void abtbtn_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
            this.Hide();

        }

        //exit button
        private void extbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        //footer dashboard
        private void footer_Paint(object sender, PaintEventArgs e)
        {

        }
        //web button
        private void urlbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://communitymangementsystem.com");
        }
        //facebook button
        private void fbbtn_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://facebook.com/communitymangementsystem");
        }
        //instagram button
        private void instbtn_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://instagram.com/communitymangementsystem");
        }
        //linkedin button
        private void lnkdbtn_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://linkedin.com/communitymangementsystem");

        }
        //youtube button
        private void utbbtn_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start("https://youtube.com/communitymangementsystem");

        }
        //Copyrights label
        private void cpyrgts_txt(object sender, EventArgs e)
        {

        }
    }
}
