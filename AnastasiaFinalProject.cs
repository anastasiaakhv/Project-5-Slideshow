using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Net;
using System.Timers;
using System.Diagnostics;

namespace AnastasiaAkhvledianiFinalProject
{
   
    // Create Interface forMypen which uses IComparable interface
    interface forMyPen : IComparable <Pen>
    {
       bool MyPenComparator(Pen myPen);
       
    }


    // Form 1 inherits from MyClassShow
    public partial class Form1 : Form, forMyPen
    {
        // Declare a list of strings
        protected List<string> MyImageCollection = new List<string>();
        protected int Counter = 0;
        protected bool on = true;
        protected bool slideShow = true;
        protected bool MainPictureBoxFront = true;

        // CompareTo method for Pens 
        public int CompareTo(Pen myPen)
        {
            Pen otherPen = new Pen(Color.Transparent);
            // If the pens color is not transparent then return 1
            if (!(myPen.Color == otherPen.Color))
            {
                return 1;
            }
            // else return 0
            else
            {
                return 0;
            }
        }

        // Demonstrating polymorphism - virtual 
        // Comparator for Pens - later will be overriden in the next class
        public  virtual bool MyPenComparator(Pen myPen)
        {
            if (CompareTo(myPen) == 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        // This function is invoked when the button is clicked 
        // MyButton => View Picture Click 
        private void MyButton_Click(object sender, EventArgs e)
        {
            // Initialization of a new WebRequest instance for the specified URI scheme
            // It is important that the link that is passed starts with a proper protocol such as: http, https, www, etc...
            //  Using try-catch to handle the exception: incorrect input format

            try
            {
                WebRequest myRequest = WebRequest.Create(MyTextBox.Text);
                string MyType = MyTextBox.Text;
                if (((MyType.Contains(".jpg")) | (MyType.Contains(".png")) | (MyType.Contains(".bmp")) | (MyType.Contains(".gif"))))
                {
                    // Get the input that was written into the Textbox
                    using (var input = myRequest.GetResponse())
                    {

                        using (var myVariable = input.GetResponseStream())
                        {
                            // Output the image of the coresponding URL
                            MyImage.Image = Bitmap.FromStream(myVariable);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("The input format is incorrect.");
                }
            }
            catch
            {
                MessageBox.Show("The input format is incorrect\nThe link has to start with a proper protocol\nhttp, thhps, www, etc");
            }
        }

        // View Previous image if button1 is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // If it is not the first picture
            if (!(Counter == 0))
            {
                // Go back 
                string prev = MyImageCollection[Counter - 1];
                // Show the picture (previous picture)
                MyImage.ImageLocation = prev;
                // Decriment counter by 1
                Counter--;
            }
            else
            {
                // In case this is the first image, inform the user that this is the first image
                MessageBox.Show("This is the first image");
            }
        }

        //  View Next image if "Next" button is pressed
        private void Next_Click(object sender, EventArgs e){
            // If this is NOT the last picture
            if (!((Counter + 1) == MyImageCollection.Count))
            {
                // Go to the next image
                string next = MyImageCollection[Counter + 1];
                // Show the image
                MyImage.ImageLocation = next;
                // Increment counter by 1
                Counter++;
            }
            else 
            {
                // If this is the last image, inform the user about this fact
                MessageBox.Show("This is the last image");
            }
        }

        //  Choose Directory when clicking this button
        private void Directory_Click(object sender, EventArgs e)
        {
            //  Using the same logic that was used when retrieving an image from a website 

            //  FolderBrowserDialog - a sealed class which prompts the user to select a folder
            using (var myInput = new FolderBrowserDialog())
            {
                //  A DialogResult represents the result of the form when used as a dialog box.
                DialogResult result = myInput.ShowDialog();
                
                //if clicked OK 
                if (result == DialogResult.OK)
                {
                    // If path is not empty or a blank string then find the image
                    if (!(string.IsNullOrEmpty(myInput.SelectedPath)) )
                        {

                        //   Get the paths and store them into the string array
                        string[] PathCollection = System.IO.Directory.GetFiles(myInput.SelectedPath);

                        // Foreach path in the collection of paths
                        foreach (var element in PathCollection)
                        {
                            // The program is able to show .jpg , .gif, .bmp and .png images
                            if ( element.EndsWith(".jpg") ) MyImageCollection.Add(element);
                           
                            if( element.EndsWith(".gif") )  MyImageCollection.Add(element);

                            if (element.EndsWith(".bmp")) MyImageCollection.Add(element);

                            if (element.EndsWith(".png")) MyImageCollection.Add(element);
                        }
                        try
                        {
                            //  Starting from the first image in MyImageCollection
                            MyImage.ImageLocation = MyImageCollection[0];
                        }
                        catch 
                        { 
                            // If the conditions are not met show the following message
                            MessageBox.Show("There are no pictures in the folder");
                        }
                    }
                        
                   
                }
            }

        }

      
        //  Go into Slideshow mood
        private void Slideshow_Click(object sender, EventArgs e)
        {
            // When the Slideshow button is clicked call the Start function

            // Switch slideshow mode on
            if (on)
            {
                Slideshow.Text = "Slideshow Mode On";
                // When the slideshow mode is on, the button color changes to coral
                Slideshow.BackColor = Color.Coral;
                // Start the timer
                timer1.Start();
                // Update value of on
                on = false;
            }
            else 
            {   
                Slideshow.Text = "Slideshow Mode Off";
                // If slideshow mode is off, the button changes color into Aquamarine
                Slideshow.BackColor = Color.Aquamarine;
                // Stop the timer
                timer1.Stop();
                // Update value of on
                on = true;
            }
            
        }

        // Default timer 
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (slideShow)
            {
                slideShow = false;
            }
            else 
            {
                slideShow = true;
            }

            if (MainPictureBoxFront)
            {
                MainPictureBoxFront = false;
            }
            else 
            {
                MainPictureBoxFront = true;
            }
            

            //  Integrating the Next function into the timer so that the slideshow is continuous

            //  If the value of the counter is not the same as the number of images in MyImageCollection
            try
            {
                //MyImage.ImageLocation = MyImageCollection[1];

                // If it is not the last image
                if (!((Counter + 1) == MyImageCollection.Count))
                {
                    //MyImage.ImageLocation = MyImageCollection[1];

                    // next gets the next imagepath
                    string next = MyImageCollection[Counter + 1];
                    CheckForIllegalCrossThreadCalls = true;
                    
                    if (MainPictureBoxFront)
                    {
                        //string next = MyImageCollection[Counter + 1];
                        // Transition - bring to front picturebox that is used for transitions
                        MyImage.SendToBack();
                        // Delay 
                        System.Threading.Thread.Sleep(1000);
                        // Bring to front the next image
                        MyImage.ImageLocation = next;

                    }
                    else 
                    {
                        // Delay
                        System.Threading.Thread.Sleep(1000);
                        // Bring the image to front
                        MyImage.BringToFront();
                        // Increment Counter by 1
                        Counter++;
                    }
                    
                 }
                else 
                {
                    // Bring the transition picturebox in front
                    MyImage.SendToBack();
                    // Delay
                    System.Threading.Thread.Sleep(1000);
                    // Bring the image to front
                    MyImage.BringToFront();
                    MyImage.ImageLocation = MyImageCollection[1];
                    
                }
  
            }
            catch
            {   
                // If it is the last image, show the following message
                MessageBox.Show("There are no more images left");
            }
            
        }

        // Set time interval
        private void button2_Click(object sender, EventArgs e)
        {
            //  Get input in seconds from user in seconds
            string myTimeintervalSecond = textBox1.Text;

            try
            {
                // Convert string to integer
                int myInput = Convert.ToInt32(textBox1.Text);
                // The input range is (0;10]
                if ((myInput > 0) && (myInput <= 10))
                {
                    // convert ms into seconds by multiplying the value by 10^3 
                    timer1.Interval = myInput * 1000;
                }
                else 
                {
                    // Show the following message
                    MessageBox.Show("Please enter a number in the range of 1 to 10");
                }
               
            }
            catch 
            {
                // Show the following message
                MessageBox.Show("The input format was inncorrect.\nPlease enter number");
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void MyImage_Paint(object sender, PaintEventArgs e)
        {
            
        }

        // Picturebox for transitions
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // this method is created for the transitions between images
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
            Pen thePen;
            
            thePen = new Pen(Color.DarkSeaGreen, 15);
            if (MyPenComparator(thePen))
            {
                SolidBrush mySolidBrush = new SolidBrush(Color.MediumAquamarine);
                Font a = new Font("Comic Sans MS", 24);
                // Write "Next Image" in the center
                e.Graphics.DrawString("Next Image", a, mySolidBrush, 100, 100);
            }
            else 
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    public class FutureImplementation : Form1 
    {
        public override bool MyPenComparator(Pen myPen)
        {
            return true;
        }
    }
}

