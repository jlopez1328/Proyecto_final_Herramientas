using Newtonsoft.Json;
using Proyecto_final_Herramientas.Helpers;
using Proyecto_final_Herramientas.Helpers.Modelos;
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
    public partial class Login : Form
    {
        public Login()
        {
            try
            {
                InitializeComponent();

                //Si no existen usuarios registrados previamente establecemos el usuario por defecto
                if (string.IsNullOrEmpty(Settings.Usuarios)) 
                {
                    var usuarios = new List<Usuario>
                    {
                        new Usuario
                        {
                            User = "admin",
                            Clave = "admin123"
                        }
                    };

                    Settings.Usuarios = JsonConvert.SerializeObject(usuarios);
                }

                TXT_Usuario.Focus();
            }
            catch (Exception)
            {

            }
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificamos que se haya ingresado un usuario
                if (TXT_Usuario.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar su usuario", "Advertencia");
                    TXT_Usuario.Focus();
                    return;
                }

                //Verificamos que se haya ingresado una contraseña
                if (TXT_Clave.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar su contraseña", "Advertencia");
                    TXT_Clave.Focus();
                    return;
                }

                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(Settings.Usuarios);
                var usuario = usuarios.FirstOrDefault(u => u.User == TXT_Usuario.Text && u.Clave == TXT_Clave.Text);

                if (usuario != null)
                {
                    this.Visible = false;
                    //Crear nuevo forms
                    var registro = new Registro();
                    registro.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Advertencia");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }

        }//Fin BTN_Login_Click(){...}

        private void BTN_Registrarse_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                var registro = new Registro();
                registro.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }
        }

        private void TXT_Clave_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    BTN_Login_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }
        }

        private void TXT_Clave_TextChanged(object sender, EventArgs e)
        {
            TXT_Clave.ForeColor = Color.DimGray;
            TXT_Clave.PasswordChar = '*';
        }

        private void TXT_Usuario_TextChanged(object sender, EventArgs e)
        {
            TXT_Clave.ForeColor = Color.DimGray;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
