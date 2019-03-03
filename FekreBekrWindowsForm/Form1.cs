
namespace FekreBekrWindowsForm
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private System.Drawing.Color MyBackColor = System.Drawing.Color.Black;

        private System.Drawing.Point MyLocation;

        private void SetDefultBackColor()
        {
            roundButton1.BackColor = System.Drawing.Color.Black;

            roundButton2.BackColor = System.Drawing.Color.Black;

            roundButton3.BackColor = System.Drawing.Color.Black;

            roundButton4.BackColor = System.Drawing.Color.Black;
        }

        private void SetNewButtomLocation(int x, int y)
        {
            MyLocation.X = x;

            MyLocation.Y = y - 49;
        }

        //private void SetRadioButtonDefult()
        //{
        //    red.Checked = false;

        //    blue.Checked = false;

        //    green.Checked = false;

        //    yellow.Checked = false;

        //    fuchsia.Checked = false;

        //    withe.Checked = false;

        //}

        private System.Drawing.Color[] Qestion;

        private System.Drawing.Color[] Answer;

        private System.Drawing.Color[] Help;

        private void CheckAnswer(System.Drawing.Color[] answer)
        {
            int result = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Qestion[i] == answer[i])
                {
                    Help[i] = System.Drawing.Color.White;
                    result++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Qestion[i] == answer[j])
                        {
                            Help[i] = System.Drawing.Color.Black;
                            break;
                        }
                        else
                        {
                            Help[i] = System.Drawing.Color.Brown;
                        }
                    }
                }
            }

            if (result == 4)
            {
                Help[0] = System.Drawing.Color.BlueViolet;
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //set the function too start a new game
            for (int i = 0; i < 4; i++)
            {
                Qestion[i] = GetRandomGame.getrandom();
            }
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
            if (MyBackColor == System.Drawing.Color.Black)
            {
                System.Windows.Forms.MessageBox.Show("لطفاً یک رنگ را انتخاب نمائید");
            }
            else
            {
                roundButton1.BackColor = MyBackColor;
            }
        }

        private void withe_CheckedChanged(object sender, System.EventArgs e)
        {
            if (withe.Checked == true)
            {
                MyBackColor = System.Drawing.Color.White;
            }
        }

        private void roundButton2_Click(object sender, System.EventArgs e)
        {
            if (MyBackColor == System.Drawing.Color.Black)
            {
                System.Windows.Forms.MessageBox.Show("لطفاً یک رنگ را انتخاب نمائید");
            }
            else
            {
                roundButton2.BackColor = MyBackColor;
            }
        }

        private void accept_Click(object sender, System.EventArgs e)
        {
            #region if next chance
            if (roundButton1.BackColor != System.Drawing.Color.Black &&
                roundButton2.BackColor != System.Drawing.Color.Black &&
                roundButton3.BackColor != System.Drawing.Color.Black &&
                roundButton4.BackColor != System.Drawing.Color.Black)
            {
                Answer[0] = roundButton1.BackColor;

                Answer[1] = roundButton2.BackColor;

                Answer[2] = roundButton3.BackColor;

                Answer[3] = roundButton4.BackColor;

                CheckAnswer(Answer);

                if (Help[0] == System.Drawing.Color.BlueViolet)
                {
                    System.Windows.Forms.MessageBox.Show("شما برنده شدید.");

                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    SetNewButtomLocation(roundButton1.Location.X, roundButton1.Location.Y);

                    roundButton1.Location = MyLocation;

                    SetDefultBackColor();

                    roundButton1.BackColor = MyBackColor;

                    SetNewButtomLocation(roundButton2.Location.X, roundButton2.Location.Y);

                    roundButton2.Location = MyLocation;

                    SetDefultBackColor();

                    roundButton2.BackColor = MyBackColor;

                    SetNewButtomLocation(roundButton3.Location.X, roundButton3.Location.Y);

                    roundButton3.Location = MyLocation;

                    SetDefultBackColor();

                    roundButton3.BackColor = MyBackColor;

                    SetNewButtomLocation(roundButton4.Location.X, roundButton4.Location.Y);

                    roundButton4.Location = MyLocation;

                    SetDefultBackColor();

                    roundButton4.BackColor = MyBackColor;
                }

                //set new function to check the solotion

                //SetRadioButtonDefult();
            }
            #endregion/if next chance

            else
            {
                System.Windows.Forms.MessageBox.Show("لطفاً تمام مقادیر را وارد نمایید.");
            }

        }

        private void roundButton3_Click(object sender, System.EventArgs e)
        {
            if (MyBackColor == System.Drawing.Color.Black)
            {
                System.Windows.Forms.MessageBox.Show("لطفاً یک رنگ را انتخاب نمائید");
            }
            else
            {
                roundButton3.BackColor = MyBackColor;
            }
        }

        private void roundButton4_Click(object sender, System.EventArgs e)
        {
            if (MyBackColor == System.Drawing.Color.Black)
            {
                System.Windows.Forms.MessageBox.Show("لطفاً یک رنگ را انتخاب نمائید");
            }
            else
            {
                roundButton4.BackColor = MyBackColor;
            }
        }

        private void blue_CheckedChanged(object sender, System.EventArgs e)
        {
            if (blue.Checked == true)
            {
                MyBackColor = System.Drawing.Color.Blue;
            }
        }

        private void red_CheckedChanged(object sender, System.EventArgs e)
        {
            if (red.Checked == true)
            {
                MyBackColor = System.Drawing.Color.Red;
            }
        }

        private void green_CheckedChanged(object sender, System.EventArgs e)
        {
            if (green.Checked == true)
            {
                MyBackColor = System.Drawing.Color.Green;
            }
        }

        private void yellow_CheckedChanged(object sender, System.EventArgs e)
        {
            if (yellow.Checked == true)
            {
                MyBackColor = System.Drawing.Color.Yellow;
            }
        }

        private void fuchsia_CheckedChanged(object sender, System.EventArgs e)
        {
            if (fuchsia.Checked == true)
            {
                MyBackColor = System.Drawing.Color.Fuchsia;
            }
        }
    }
}
