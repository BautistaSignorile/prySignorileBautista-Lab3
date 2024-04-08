using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySignorileBautista_Lab3
{
    public partial class frmFirma : Form
    {
        public Bitmap archivoImagen;
        public frmFirma()
        {
            InitializeComponent();
            archivoImagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            //dibujo que vaya poniendo puntos 
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(archivoImagen))
                {
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(archivoImagen, Point.Empty);
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            archivoImagen.Save("Experimento.jpg");
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal Principal = new frmPrincipal();
            Principal.ShowDialog();
        }
    }
}
