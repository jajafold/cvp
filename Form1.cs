using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace VideoPlayer2
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form();
            form1.Show();
            form1.WindowState = FormWindowState.Maximized;
            Video movie = new Video("C:\\Users\\Оля\\Desktop\\фото\\дпмм\\IMG_2162.MOV");
            movie.Owner = form1;
            movie.Size = new Size(1920, 1080);
            movie.Play();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}

