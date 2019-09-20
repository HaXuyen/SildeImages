using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide
{
    public partial class Form1 : Form
    {
        private static int i;
        private static string[] pic = new string[]
        {
            @"D:\web\bai2js\img\anh1.jpg",
             @"D:\web\bai2js\img\anh2.jpg",
              @"D:\web\bai2js\img\anh3.jpg",
               @"D:\web\bai2js\img\anh4.jpg",
                @"D:\web\bai2js\img\anh5.jpg",
                 @"D:\web\bai2js\img\anh6.jpg",

        };
        public Form1()
        {
            InitializeComponent();
            button1.Text = "prev";
            button2.Text = "next";
            
            pictureBox1.ImageLocation = pic[i];
            pictureBox2.ImageLocation = pic[i+1];
            pictureBox3.ImageLocation = pic[i+2];
            pictureBox4.ImageLocation = pic[i+3];
            pictureBox5.ImageLocation = pic[i+4];
            pictureBox6.ImageLocation = pic[i+5];
        }
        int j = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            j++;
            pictureBox1.ImageLocation = pic[j];
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
                i = pic.Length;
            i -= 1;
            pictureBox1.ImageLocation = pic[i];
     
            Text = pictureBox1.ImageLocation;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            i += 1;
            if (i == pic.Length)
                i = 0;
            pictureBox1.ImageLocation = pic[i];
            
            Text = pictureBox1.ImageLocation;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
