namespace FekreBekrWindowsForm
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int ylocation;

        private System.Drawing.Point NewLocation;


        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void roundButton1_Click(object sender, System.EventArgs e)
        {
            if (red.Checked == true)
            {
                roundButton1.BackColor = System.Drawing.Color.Red;
            }
            if (blue.Checked==true)
            {
                roundButton1.BackColor = System.Drawing.Color.Blue;
            }
            if (green.Checked == true)
            {
                roundButton1.BackColor = System.Drawing.Color.Green;
            }
            if (yellow.Checked == true)
            {
                roundButton1.BackColor = System.Drawing.Color.Yellow;
            }
            if (fuchsia.Checked==true)
            {
                roundButton1.BackColor = System.Drawing.Color.Fuchsia;
            }
            if (withe.Checked==true)
            {
                roundButton1.BackColor = System.Drawing.Color.White;
            }
        }

        private void withe_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, System.EventArgs e)
        {
            if (red.Checked == true)
            {
                roundButton2.BackColor = System.Drawing.Color.Red;
            }
            if (blue.Checked == true)
            {
                roundButton2.BackColor = System.Drawing.Color.Blue;
            }
            if (green.Checked == true)
            {
                roundButton2.BackColor = System.Drawing.Color.Green;
            }
            if (yellow.Checked == true)
            {
                roundButton2.BackColor = System.Drawing.Color.Yellow;
            }
            if (fuchsia.Checked == true)
            {
                roundButton2.BackColor = System.Drawing.Color.Fuchsia;
            }
            if (withe.Checked == true)
            {
                roundButton2.BackColor = System.Drawing.Color.White;
            }
        }

        private void accept_Click(object sender, System.EventArgs e)
        {
            if (roundButton1.BackColor != System.Drawing.Color.Black &&
                roundButton2.BackColor != System.Drawing.Color.Black &&
                roundButton3.BackColor != System.Drawing.Color.Black &&
                roundButton4.BackColor != System.Drawing.Color.Black)
            {
                ylocation = roundButton1.Location.Y;

                buttonchanges newlocation = new buttonchanges(ylocation);

                NewLocation.Y = newlocation.getlocation();

                NewLocation.X = roundButton1.Location.X;

                roundButton1.Location = NewLocation;

                roundButton1.BackColor = System.Drawing.Color.Black;

                NewLocation.X = roundButton2.Location.X;

                roundButton2.Location = NewLocation;

                roundButton2.BackColor = System.Drawing.Color.Black;

                NewLocation.X = roundButton3.Location.X;

                roundButton3.Location = NewLocation;

                roundButton3.BackColor = System.Drawing.Color.Black;

                NewLocation.X = roundButton4.Location.X;

                roundButton4.Location = NewLocation;

                roundButton4.BackColor = System.Drawing.Color.Black;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("لطفامقادیر را وارد کنید");
            }
        }

        private void roundButton3_Click(object sender, System.EventArgs e)
        {
            if (red.Checked == true)
            {
                roundButton3.BackColor = System.Drawing.Color.Red;
            }
            if (blue.Checked == true)
            {
                roundButton3.BackColor = System.Drawing.Color.Blue;
            }
            if (green.Checked == true)
            {
                roundButton3.BackColor = System.Drawing.Color.Green;
            }
            if (yellow.Checked == true)
            {
                roundButton3.BackColor = System.Drawing.Color.Yellow;
            }
            if (fuchsia.Checked == true)
            {
                roundButton3.BackColor = System.Drawing.Color.Fuchsia;
            }
            if (withe.Checked == true)
            {
                roundButton3.BackColor = System.Drawing.Color.White;
            }
        }

        private void roundButton4_Click(object sender, System.EventArgs e)
        {
            if (red.Checked == true)
            {
                roundButton4.BackColor = System.Drawing.Color.Red;
            }
            if (blue.Checked == true)
            {
                roundButton4.BackColor = System.Drawing.Color.Blue;
            }
            if (green.Checked == true)
            {
                roundButton4.BackColor = System.Drawing.Color.Green;
            }
            if (yellow.Checked == true)
            {
                roundButton4.BackColor = System.Drawing.Color.Yellow;
            }
            if (fuchsia.Checked == true)
            {
                roundButton4.BackColor = System.Drawing.Color.Fuchsia;
            }
            if (withe.Checked == true)
            {
                roundButton4.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
