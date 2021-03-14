using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_changetd_to_cities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bakubutton_MouseHover(object sender, EventArgs e)
        {

            LabalImage.Image = this.LabalImage.Image = global::Time_changetd_to_cities.Properties.Resources.B;
            Timelabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:MM");
        }

        private void LabalImage_Click(object sender, EventArgs e)
        {

        }

        private void Londonbutton_MouseHover(object sender, EventArgs e)
        {
            LabalImage.Image = this.LabalImage.Image = global::Time_changetd_to_cities.Properties.Resources.L;
            DateTime myDate = DateTime.Now;
            DateTime updated = myDate.Add(new TimeSpan(-4, 0, 0));

       
            Timelabel.Text = updated.ToString("yyyy/MM/dd HH:MM");

            

        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
