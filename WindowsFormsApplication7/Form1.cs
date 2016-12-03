using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        int k = 0;
        public Form1()
        {
            InitializeComponent();
            load();


        }
        public void load()
        {

            Database1Entities5 con = new Database1Entities5();

            Table new1 = new Table();
            new1 = con.Table.Single(s => s.Id == 1);
            textBox1.Text = new1.Header;
            pictureBox1.Image = byteArrayToImage(new1.HeaderImg);

            Table new2 = new Table();
            new2 = con.Table.Single(s => s.Id == 2);
            textBox2.Text = new2.Header; 
            pictureBox2.Image = byteArrayToImage(new2.HeaderImg);
            

           Table new3 = new Table();
            new3 = con.Table.Single(s => s.Id == 3);
            textBox3.Text = new3.Header;
            pictureBox3.Image = byteArrayToImage(new3.HeaderImg);
 
            Table new4 = new Table();
            new4 = con.Table.Single(s => s.Id == 4);
            textBox4.Text = new4.Header; 
            pictureBox4.Image = byteArrayToImage(new4.HeaderImg);

            Table new5 = new Table();
            new5 = con.Table.Single(s => s.Id == 5);
            textBox5.Text = new5.Header;
            pictureBox5.Image = byteArrayToImage(new5.HeaderImg);

            Table new6 = new Table();
            new6 = con.Table.Single(s => s.Id == 6);
            textBox6.Text = new6.Header; 
            pictureBox6.Image = byteArrayToImage(new6.HeaderImg);

            Table new7 = new Table();
            new7 = con.Table.Single(s => s.Id == 7);
            textBox7.Text = new7.Header; 
            pictureBox7.Image = byteArrayToImage(new7.HeaderImg);

            Table new8 = new Table();
            new8 = con.Table.Single(s => s.Id == 8);
            textBox8.Text = new8.Header; 
            pictureBox8.Image = byteArrayToImage(new8.HeaderImg);

            Table new9 = new Table();
            new9 = con.Table.Single(s => s.Id == 9);
            textBox9.Text = new9.Header; 
            pictureBox9.Image = byteArrayToImage(new9.HeaderImg);

            Table new10 = new Table();
            new10 = con.Table.Single(s => s.Id == 10);
            textBox10.Text = new10.Header; 
            pictureBox10.Image = byteArrayToImage(new10.HeaderImg);

            Table new11 = new Table();
            new11 = con.Table.Single(s => s.Id == 11);
            textBox11.Text = new11.Header; 
            pictureBox11.Image = byteArrayToImage(new11.HeaderImg);

            Table new12 = new Table();
            new12 = con.Table.Single(s => s.Id == 12);
            textBox12.Text = new12.Header; 
            pictureBox12.Image = byteArrayToImage(new12.HeaderImg);

        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void make(int k)
        {
            Database1Entities5 con = new Database1Entities5();
            Table new10 = new Table();
            new10 = con.Table.Single(s => s.Id == k);
            News temp = new News();
            temp.Text = new10.News;
            temp.Img1 = byteArrayToImage(new10.Img1);
            temp.Img2 = byteArrayToImage(new10.Img2);
            Form2 neww = new Form2(temp);
            neww.Text = new10.Header;
            neww.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            make(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            make(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            make(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            make(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            make(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            make(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            make(7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            make(8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            make(9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            make(10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            make(11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            make(12);
        }
    }
}
