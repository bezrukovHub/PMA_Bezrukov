using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form2 : Form
    {
        public News dataa;
        string temp = "";
        string now;
        int n = 162;
        int start;
        public ArrayList ing = new ArrayList();
        public List<Color> Colors = new List<Color>();
        int i = 0, j = 0;

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public Form2(News _dataa)
        {
            start = n;
            dataa = new News();
            InitializeComponent();

            textBox1.BackColor = Color.Azure;
            Colors.Add(Color.Azure);
            Colors.Add(Color.Aquamarine);
            Colors.Add(Color.Gainsboro);
            Colors.Add(Color.PaleGreen);
            Colors.Add(Color.MistyRose);
            Colors.Add(Color.PowderBlue);
            Colors.Add(Color.PeachPuff);

            j = 0;
            dataa = _dataa;
            temp = dataa.Text;
            now = "";
            for (int i = 0; i < n; i++)
            {
                now += temp[i];
            }

                ing.Add(dataa.Img1);
                ing.Add(dataa.Img2);
            backgroundWorker1.RunWorkerAsync();
}

        private void timer1_Tick(object sender, EventArgs e)
        {
            string te = "";
            

            start++;
            if (start == temp.Length) { start = 0; }

            now += temp[start];
            for (int i = 1; i < n; i++)
            { te += now[i]; }
            now = te;
            textBox1.Text = now;
            
            i++;
            if (i % 19 == 0)
                
                {
                    j++;
                    textBox1.BackColor = Colors[j % 7];
                }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (1 != 0)
            {
                pictureBox1.Image = (Image)ing[i % 2];           
                System.Threading.Thread.Sleep(2100);
               
            }
            
        }
    }
}
