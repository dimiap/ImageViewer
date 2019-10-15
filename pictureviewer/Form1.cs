using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace pictureviewer
{
    public partial class Pictureviewer_form : Form
    {
        private string[] folder = null; //string sto opoio apothikeuo tis eikones pou anoiksa apo to folderbrowserdialog, tis apothikeuo sto folder oste na kano epomenh prohgoumenh photo
        Image imgOriginal; //gia na ftiaxno kainourgia eikona (pio megenthimenh) meta apo to zoom in
        private int img = 0; //deikths gia na ksero an pathsa mpros 'h piso
        private int first = 0; //deikths proths eikonas
        private int last = 0; //deikths teleutaias eikonas 
        public Pictureviewer_form()
        {
            InitializeComponent();
        }
        //gia na kano to save as
        private void αποθήκευσηΩςToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Image file|*.jpg, *.png";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε πρώτα μια εικόνα για να αποθηκεύσεις");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(saveFileDialog1.FileName);

                    saveFileDialog1.DefaultExt = ".Jpg";
                    saveFileDialog1.Filter = "Image (.jpg)|*.jpg";
                    saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                }
            }
        }
        //gia na anoikso fakelo gia tis eikones
        private void open_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] imag1 = null, imag2 = null, imag3 = null;
                //epilego anamesa se jpg,jpeg kai bmp
                imag1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg"); 
                imag2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpeg");
                imag3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.bmp");

                folder = new string[imag1.Length + imag2.Length + imag3.Length];

                Array.Copy(imag1, 0, folder, 0, imag1.Length);
                Array.Copy(imag2, 0, folder, imag1.Length, imag2.Length);
                Array.Copy(imag3, 0, folder, imag1.Length + imag2.Length, imag3.Length);

                img = 0;
                first = 0;
                last = folder.Length; //to teleutaio stoixeio kanei ousiastika ton deikth ton teleutaio 
                
                showImg(folder[img]);
            }
                Bitmap pic3 = (Bitmap)pictureBox1.Image;
                //pairnoume to width kai to height gia to richtextbox
                int width = pic3.Width;
                int height = pic3.Height;
                string name = Path.GetFileName(pictureBox1.ImageLocation);
                info_richTextBox.AppendText("Width " + width + " Height " + height + System.Environment.NewLine);

            
        }
        //gia na kleiso thn efarmogi
        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void άνοιγμαΕικόναςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] imag1 = null, imag2 = null, imag3 = null;

                imag1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                imag2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpeg");
                imag3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.bmp");

                folder = new string[imag1.Length + imag2.Length + imag3.Length];

                Array.Copy(imag1, 0, folder, 0, imag1.Length);
                Array.Copy(imag2, 0, folder, imag1.Length, imag2.Length);
                Array.Copy(imag3, 0, folder, imag1.Length + imag2.Length, imag3.Length);

                img = 0;
                first = 0;
                last = folder.Length;

                showImg(folder[img]);
            }
            Bitmap pic3 = (Bitmap)pictureBox1.Image;
            int width = pic3.Width;
            int height = pic3.Height;
            info_richTextBox.AppendText("Width " + width + " Height " + height + System.Environment.NewLine);
        }
        //gia na deikso thn eikona pou dialeksa apo to folderbrowser me to path tou string folder
        private void showImg(string path)
        {
            Image img = Image.FromFile(path);
            pictureBox1.Image = img;
            imgOriginal = img;
        }
        //to prohgoymeno koumpi
        public void previous_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please choose a photo first"); //an dn exoume dialeksei eikona
            }
            else
            {
                if (img == 0)
                {
                    img = folder.Length - 1;
                    showImg(folder[img]);
                }
                else
                {
                    img = img - 1;
                    showImg(folder[img]);
                }
                trackBar1.Value = 0; //midenizetai to zoum
                info_richTextBox.Clear();
                Bitmap pic3 = (Bitmap)pictureBox1.Image;
                //allazoun kai ta width kai height ths eikonas
                int width = pic3.Width;
                int height = pic3.Height;
                info_richTextBox.AppendText("Width " + width + " Height " + height + System.Environment.NewLine);
            }
        }
        //epomeno koumpi
        public void next_button_Click(object sender, EventArgs e)
        {
            nxtImage(); 
        }
        //gia na kano thn eikona streched
        int a;
        private void streched_button_Click(object sender, EventArgs e)
        {
            a++;
            //an patame to koumpi arties fores tha einai kanonikh allios tha einai streched
            if (a % 2 == 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void strechΕικόναςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a++;
            if (a % 2 == 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        //gia na anoikso thn deuterh forma me tis pollaples eikones
        private void multi_button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        //gia na kanei peristrofi deksia 
        private void right_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Eπέλεξε μια φωτογραφία πρώτα");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = img;
            }
        }
        //gia na kanei peristrofh aristera
        private void left_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε μια φωτογραφία πρώτα");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
        }

        private void δεξιόστροφαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Eπέλεξε μια φωτογραφία πρώτα");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = img;
            }
        }

        private void αριστερόστροφαToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε μια φωτογραφία πρώτα");
            }
            else
            {
                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
        }
        //gia na kanei to aspromauro 
        int b;
        private void grayscale_button_Click(object sender, EventArgs e)
        {
            Bitmap pic1 = (Bitmap)pictureBox1.Image;
            int width = pic1.Width;
            int height = pic1.Height;
            Color p;
            b++;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε μια εικόνα πρώτα");
            }
            else
            {
                if (b % 2 != 0)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            //get pixel value
                            p = pic1.GetPixel(x, y);

                            //extract pixel component ARGB
                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            //find average
                            int avg = (r + g + b) / 3;

                            //set new pixel value
                            pic1.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                            pictureBox1.Image = pic1;
                        }
                    }
                }
                
            }
        }
        //gia na kanei sepia thn photo mas
        private void sepia_button_Click(object sender, EventArgs e)
        {
            Bitmap pic2 = (Bitmap)pictureBox1.Image;
            int width = pic2.Width;
            int height = pic2.Height;
            Color p;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε μια εικόνα πρώτα");
            }
            else
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        
                        p = pic2.GetPixel(x, y);

                        
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        
                        int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                        int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                        int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                        
                        if (tr > 255)
                        {
                            r = 255;
                        }
                        else
                        {
                            r = tr;
                        }

                        if (tg > 255)
                        {
                            g = 255;
                        }
                        else
                        {
                            g = tg;
                        }

                        if (tb > 255)
                        {
                            b = 255;
                        }
                        else
                        {
                            b = tb;
                        }

                        
                        pic2.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox1.Image = pic2;


            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image pict1 = pictureBox1.Image;
            Bitmap pic1 = (Bitmap)pictureBox1.Image;
            int width = pic1.Width;
            int height = pic1.Height;
            Color p;
            b++;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε μια εικόνα πρώτα");
            }
            else
            {
                if (b % 2 != 0)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            
                            p = pic1.GetPixel(x, y);

                            
                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            
                            int avg = (r + g + b) / 3;

                            
                            pic1.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                            pictureBox1.Image = pic1;
                        }
                    }
                }
                else
                {
                    pictureBox1.Image = pict1;
                }
            }
        }
        int c;
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image pict2 = pictureBox1.Image;
            Bitmap pic2 = (Bitmap)pictureBox1.Image;
            int width = pic2.Width;
            int height = pic2.Height;
            Color p;
            c = 0;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Επέλεξε μια εικόνα πρώτα");
            }
            else
            {
                if (c % 2 != 0)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            //get pixel value
                            p = pic2.GetPixel(x, y);

                            //extract pixel component ARGB
                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            //calculate temp value
                            int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                            int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                            int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                            //set new RGB value
                            if (tr > 255)
                            {
                                r = 255;
                            }
                            else
                            {
                                r = tr;
                            }

                            if (tg > 255)
                            {
                                g = 255;
                            }
                            else
                            {
                                g = tg;
                            }

                            if (tb > 255)
                            {
                                b = 255;
                            }
                            else
                            {
                                b = tb;
                            }

                            //set the new RGB value in image pixel
                            pic2.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        }
                    }
                    pictureBox1.Image = pic2;
                }
                else
                {
                    pictureBox1.Image = pict2;
                }

            }
        }
        //sunartish pou ftiaxnei to zoom
        Image Zoom(Image img, Size size)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("You have not selected an image. Press open to select one.");
            }
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }
        //gia na ftiakso to trackbar tou zoom
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if ((trackBar1.Value > 0) && (imgOriginal != null))
            {
                
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
        }
        //sunartisi pou kanoume gia thn epomenh eikona
        private void nxtImage()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please choose a photo first");
            }
            else
            {
                if (img == folder.Length - 1)
                {
                    img = 0;
                    showImg(folder[img]);
                }
                else
                {
                    img = img + 1;
                    showImg(folder[img]);
                }
                trackBar1.Value = 0; //midenizei to zoom
                info_richTextBox.Clear();//allazei to richtextbox
                Bitmap pic3 = (Bitmap)pictureBox1.Image;
                int width = pic3.Width;
                int height = pic3.Height;
                info_richTextBox.AppendText("Width " + width + " Height " + height + System.Environment.NewLine);
            }

        }
        //gia to slideshow
        private void timer1_Tick(object sender, EventArgs e)
        {
            nxtImage();
        }
        int d;
        //otan patao to slideshow na arxizei o xronos gia na gurnane oi eikones kai otan to ksanapatao na stamataei 
        private void slideshow_button_Click(object sender, EventArgs e)
        {
            d++;
            if (d %2 == 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void επόμενηΕικόναToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nxtImage();
        }

        private void προηγούμενηΕικόναToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please choose a photo first");
            }
            else
            {
                if (img == 0)
                {
                    img = folder.Length - 1;
                    showImg(folder[img]);
                }
                else
                {
                    img = img - 1;
                    showImg(folder[img]);
                }
            }
        }
        
        private void slideshowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d++;
            if (d % 2 == 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void Pictureviewer_form_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
        }
    }

}
