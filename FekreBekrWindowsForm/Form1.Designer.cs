namespace FekreBekrWindowsForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accept = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.withe = new System.Windows.Forms.RadioButton();
            this.fuchsia = new System.Windows.Forms.RadioButton();
            this.yellow = new System.Windows.Forms.RadioButton();
            this.green = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton4 = new FekreBekrWindowsForm.RoundButton();
            this.roundButton3 = new FekreBekrWindowsForm.RoundButton();
            this.roundButton2 = new FekreBekrWindowsForm.RoundButton();
            this.roundButton1 = new FekreBekrWindowsForm.RoundButton();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.Peru;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Location = new System.Drawing.Point(209, 466);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(49, 42);
            this.accept.TabIndex = 0;
            this.accept.Text = "تایید";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Peru;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("B Kamran", 14F);
            this.clear.Location = new System.Drawing.Point(129, 466);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(49, 42);
            this.clear.TabIndex = 1;
            this.clear.Text = "تکرار";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // withe
            // 
            this.withe.AutoSize = true;
            this.withe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withe.Location = new System.Drawing.Point(45, 443);
            this.withe.Name = "withe";
            this.withe.Size = new System.Drawing.Size(13, 12);
            this.withe.TabIndex = 2;
            this.withe.TabStop = true;
            this.withe.UseVisualStyleBackColor = true;
            this.withe.CheckedChanged += new System.EventHandler(this.withe_CheckedChanged);
            // 
            // fuchsia
            // 
            this.fuchsia.AutoSize = true;
            this.fuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.fuchsia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fuchsia.Location = new System.Drawing.Point(84, 443);
            this.fuchsia.Name = "fuchsia";
            this.fuchsia.Size = new System.Drawing.Size(13, 12);
            this.fuchsia.TabIndex = 3;
            this.fuchsia.TabStop = true;
            this.fuchsia.UseVisualStyleBackColor = false;
            this.fuchsia.CheckedChanged += new System.EventHandler(this.fuchsia_CheckedChanged);
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yellow.Location = new System.Drawing.Point(125, 443);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(13, 12);
            this.yellow.TabIndex = 4;
            this.yellow.TabStop = true;
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.CheckedChanged += new System.EventHandler(this.yellow_CheckedChanged);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.green.Location = new System.Drawing.Point(165, 443);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(13, 12);
            this.green.TabIndex = 5;
            this.green.TabStop = true;
            this.green.UseVisualStyleBackColor = false;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.red.Location = new System.Drawing.Point(205, 443);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(13, 12);
            this.red.TabIndex = 6;
            this.red.TabStop = true;
            this.red.UseVisualStyleBackColor = false;
            this.red.CheckedChanged += new System.EventHandler(this.red_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blue.Location = new System.Drawing.Point(245, 443);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(13, 12);
            this.blue.TabIndex = 7;
            this.blue.TabStop = true;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.CheckedChanged += new System.EventHandler(this.blue_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "به بازی فکر بکر خوش آمدید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "آقا/خانم";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "حسین کلانکی";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(48, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Black;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton4.Location = new System.Drawing.Point(241, 398);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(14, 15);
            this.roundButton4.TabIndex = 19;
            this.roundButton4.Text = "roundButton4";
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Black;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton3.Location = new System.Drawing.Point(203, 398);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(14, 15);
            this.roundButton3.TabIndex = 18;
            this.roundButton3.Text = "roundButton3";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Black;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton2.Location = new System.Drawing.Point(165, 398);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(14, 15);
            this.roundButton2.TabIndex = 17;
            this.roundButton2.Text = "roundButton2";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Black;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton1.Location = new System.Drawing.Point(126, 398);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(14, 15);
            this.roundButton1.TabIndex = 16;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FekreBekrWindowsForm.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(309, 517);
            this.ControlBox = false;
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.fuchsia);
            this.Controls.Add(this.withe);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.accept);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton blue;
        public System.Windows.Forms.RadioButton withe;
        public System.Windows.Forms.RadioButton fuchsia;
        public System.Windows.Forms.RadioButton yellow;
        public System.Windows.Forms.RadioButton green;
        public System.Windows.Forms.RadioButton red;
        public RoundButton roundButton1;
        public RoundButton roundButton2;
        public RoundButton roundButton3;
        public RoundButton roundButton4;
    }
}

