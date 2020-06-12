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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

      
        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void abtext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abthm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 h = new Form1();
            h.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
       
    }
}
