using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FekreBekrWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int Button1Location { get; set; }

        //class ButtonColor
        //{
        //    public ButtonColor(string buttonname,string radiobuttonname)
        //    {
        //        Buttonname = buttonname;
        //        Radiobuttonname = radiobuttonname;
        //    }

        //    private string Radiobuttonname;

        //    private string buttonnname;

        //    public string Buttonname
        //    {
        //        get
        //        {
        //            if (Radiobuttonname=="Red")
        //            {
                        
        //            }
        //            return buttonnname;
        //        }
        //        set
        //        {
        //            buttonnname = value;
        //        }
        //    }



        //}


        private void MainForm_Load(object sender, EventArgs e)
        {
            Button1Location = 399;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (blue.Checked == true)
            {
                roundButton1.BackColor = Color.Blue;
            }
            if (red.Checked == true)
            {
                roundButton1.BackColor = Color.Red;
            }
            if (green.Checked == true)
            {
                roundButton1.BackColor = Color.Green;
            }
            if (yellow.Checked == true)
            {
                roundButton1.BackColor = Color.Yellow;
            }
            if (fuchsia.Checked == true)
            {
                roundButton1.BackColor = Color.Fuchsia;
            }
            if (withe.Checked == true)
            {
                roundButton1.BackColor = Color.White;
            }
        }

        private void withe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (blue.Checked == true)
            {
                roundButton2.BackColor = Color.Blue;
                
            }
            if (red.Checked == true)
            {
                roundButton2.BackColor = Color.Red;
            }
            if (green.Checked == true)
            {
                roundButton2.BackColor = Color.Green;
            }
            if (yellow.Checked == true)
            {
                roundButton2.BackColor = Color.Yellow;
            }
            if (fuchsia.Checked == true)
            {
                roundButton2.BackColor = Color.Fuchsia;
            }
            if (withe.Checked == true)
            {
                roundButton2.BackColor = Color.White;
            }

        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (accept.Text=="تایید")
            {
                roundButton1.Enabled = false;

                roundButton2.Enabled = false;

                roundButton3.Enabled = false;

                roundButton4.Enabled = false;

                accept.Text = "تکمیل";
            }

            else
            {
                roundButton1.Enabled = true;

                roundButton1.Location = new Point(128, 349);

                roundButton2.Enabled = true;

                roundButton2.Location = new Point(166, 349);

                roundButton3.Enabled = true;

                roundButton3.Location = new Point(203, 349);

                roundButton4.Enabled = true;

                roundButton4.Location = new Point(241, 349);
            }


        }
    }
}
