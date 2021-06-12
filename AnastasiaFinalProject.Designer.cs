namespace AnastasiaAkhvledianiFinalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MyButton = new System.Windows.Forms.Button();
            this.MyImage = new System.Windows.Forms.PictureBox();
            this.MyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Slideshow = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MyButton
            // 
            this.MyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MyButton.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.MyButton, "MyButton");
            this.MyButton.Name = "MyButton";
            this.MyButton.UseVisualStyleBackColor = false;
            this.MyButton.Click += new System.EventHandler(this.MyButton_Click);
            // 
            // MyImage
            // 
            this.MyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MyImage, "MyImage");
            this.MyImage.Name = "MyImage";
            this.MyImage.TabStop = false;
            this.MyImage.Paint += new System.Windows.Forms.PaintEventHandler(this.MyImage_Paint);
            // 
            // MyTextBox
            // 
            resources.ApplyResources(this.MyTextBox, "MyTextBox");
            this.MyTextBox.Name = "MyTextBox";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Slideshow
            // 
            this.Slideshow.BackColor = System.Drawing.Color.Fuchsia;
            this.Slideshow.Cursor = System.Windows.Forms.Cursors.Default;
            this.Slideshow.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Slideshow, "Slideshow");
            this.Slideshow.Name = "Slideshow";
            this.Slideshow.UseVisualStyleBackColor = false;
            this.Slideshow.Click += new System.EventHandler(this.Slideshow_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Fuchsia;
            this.Next.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Next, "Next");
            this.Next.Name = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Directory
            // 
            this.Directory.BackColor = System.Drawing.Color.Fuchsia;
            this.Directory.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Directory, "Directory");
            this.Directory.Name = "Directory";
            this.Directory.UseVisualStyleBackColor = false;
            this.Directory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Slideshow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyTextBox);
            this.Controls.Add(this.MyImage);
            this.Controls.Add(this.MyButton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button MyButton;
        private System.Windows.Forms.PictureBox MyImage;
        private System.Windows.Forms.TextBox MyTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Slideshow;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Directory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

