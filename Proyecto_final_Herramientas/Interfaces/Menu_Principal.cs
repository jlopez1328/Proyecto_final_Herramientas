using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_Herramientas.Interfaces
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                var entradas = new Acompañantes();
                entradas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                var platos_fuertes = new Platos_fuertes();
                platos_fuertes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }
        }

        private void Comidas_Rapidas_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                var comidas_rapidas = new Comidas_Rapidas();
                comidas_rapidas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }
        }

        private void Bebidas_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                var bebidas = new Bebidas();
                bebidas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }
        }
    }
}
