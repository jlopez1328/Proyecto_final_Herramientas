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
    public partial class Registro : Form
    {
        public Registro()
        {
            try
            {
                InitializeComponent();
                TXT_Usuario.Focus();
            }
            catch (Exception)
            {

            }
            
        }


        private void BTN_Registrarse_Click(object sender, EventArgs e)
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

                //Verificamos que se haya ingresado la verificación de la contraseña
                if (TXT_VerificarClave.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar la verificación de la contraseña", "Advertencia");
                    TXT_VerificarClave.Focus();
                    return;
                }

                if (TXT_Clave.Text != TXT_VerificarClave.Text)
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden", "Advertencia");
                    TXT_VerificarClave.Focus();
                    return;
                }
                //Convertidor de Json de un string a un objeto(listas)
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(Settings.Usuarios);

                //Verificamos que el usuario no este registrado previamente en la lista
                var usuario = usuarios.FirstOrDefault(u => u.User == TXT_Usuario.Text && u.Clave == TXT_Clave.Text);

                if (usuario == null)
                {
                    //Agregamos el nuevo usuario a la lista de usuarios
                    usuarios.Add(new Usuario
                    {
                        Clave = TXT_Clave.Text,
                        User = TXT_Usuario.Text
                    });

                    Settings.Usuarios = JsonConvert.SerializeObject(usuarios);
                    MessageBox.Show("Usuario registrado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Usuario ya se encuentra registrado", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error");
            }

        }//Fin BTN_Registrarse_Click(){...}
    }
}
