using Newtonsoft.Json;
using Proyecto_final_Herramientas.Helpers;
using Proyecto_final_Herramientas.Helpers.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_final_Herramientas.Interfaces
{
    public partial class Bebidas : ManejoProductoInterfaz
    {
        public Bebidas()
        {
            InitializeComponent();
            CHK_Cocacola_CheckedChanged(null, null);
            CHK_Postobon_CheckedChanged(null, null);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void Bebidas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CHK_Cocacola.Checked && Publico.EsNumero(TXT_CocaColaCant.Text) && Publico.EsNumero(LBL_CocacolaPrecio.Text))
                {
                    ActualizarProducto(new Producto
                    {
                        Cantidad = decimal.Parse(TXT_CocaColaCant.Text),
                        Id = LBL_CocaColaCodigo.Text,
                        Nombre = LBL_CocaColaNombre.Text,
                        Valor = decimal.Parse(LBL_CocacolaPrecio.Text)
                    });

                    if (CHK_Postobon.Checked && Publico.EsNumero(TXT_PostobonCant.Text) && Publico.EsNumero(LBL_PostobonPrecio.Text))
                    {
                        ActualizarProducto(new Producto
                        {
                            Cantidad = decimal.Parse(TXT_PostobonCant.Text),
                            Id = LBL_PostobonCodigo.Text,
                            Nombre = LBL_PostobonNombre.Text,
                            Valor = decimal.Parse(LBL_PostobonPrecio.Text)
                        });
                    }
                    else
                    {
                        EliminarProducto(LBL_PostobonCodigo.Text);
                    }
                } 
                else
                {
                    EliminarProducto(LBL_CocaColaCodigo.Text);
                }

                var menu_principal = new Menu_Principal();
                menu_principal.ShowDialog();
            }
            catch (Exception)
            {

            }
          
        }

        private void CHK_Cocacola_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Cocacola.Checked)
            {
                TXT_CocaColaCant.Text = "";
                TXT_CocaColaCant.Enabled = true;
            }
            else
            {
                TXT_CocaColaCant.Text = "";
                TXT_CocaColaCant.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Factura_Click(object sender, EventArgs e)
        {
            Form pre_factura = new PreFactura();
            pre_factura.ShowDialog();
        }

        private void TXT_CocaColaCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHK_Postobon_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Postobon.Checked)
            {
                TXT_PostobonCant.Text = "";
                TXT_PostobonCant.Enabled = true;
            }
            else
            {
                TXT_PostobonCant.Text = "";
                TXT_PostobonCant.Enabled = false;
            }
        }

        private void LBL_PostobonCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
