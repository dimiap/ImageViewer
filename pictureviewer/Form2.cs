using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureviewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //gia na kleinei h forma 2
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //gia na anoikso tis pollaples eikones 
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Please select multiple images";
            openFileDialog1.Multiselect = true; //anoigo to multiselect gia na exo thn dunatothta na valo polles eikones
            openFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int x = 20; //to orio na anoiksoume einai 20
                int y = 20; //x,y einai 20 gia na kseroume pou tha valoume tis eikones 
                int h = -1; //gia to poso megala tha einai ta picturebox
                string[] files = openFileDialog1.FileNames; //files periexei oles tis eikones pou epileksame
                foreach(string image in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(image);
                    pic.Location = new Point(x, y);//gia na valoume tis eikones 
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    x += pic.Width + 10; //poso tha einai to width 
                    h = Math.Max(pic.Height, h); //poso tha einai to max height
                    if (x > this.ClientSize.Width-100)
                    {
                        x = 20;
                        y += h + 10;
                    }
                    this.panel1.Controls.Add(pic);
                }

            }
        }
    }
}
