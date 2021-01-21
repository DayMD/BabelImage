using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace babelImage
{
    public partial class Form1 : Form
    {
        private int bitmapWidth = 640;
        private int bitmapHeight = 640;
        private int currentX = 0;
        private int currentY = 0;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            pbImageView.Image = new Bitmap(bitmapWidth, bitmapHeight);
            draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbImageView.Image.Dispose();
            //pbImageView.Image = null;
            pbImageView.Image = new Bitmap(bitmapWidth, bitmapHeight);
            draw();
        }

        private void draw()
        {
            while(currentY < bitmapHeight - 1)
            {
                //Thread.Sleep(100);
                double partWidth = (bitmapWidth / (double)16);
                
                int r = rand.Next(0, 256);
                int g = rand.Next(0, 256);
                int b = rand.Next(0, 256);
                ((Bitmap)pbImageView.Image).SetPixel(currentX, currentY, Color.FromArgb(r, g, b));
                pbImageView.Refresh();
                if (currentX < bitmapWidth - 1)
                {
                    currentX++;
                }
                else if (currentY < bitmapHeight - 1)
                {
                    currentX = 0;
                    currentY++;
                }
            }
            
        }



        private void pbImageView_Click(object sender, EventArgs e)
        {

        }


    }
}

