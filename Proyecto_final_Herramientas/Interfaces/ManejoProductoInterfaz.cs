using Newtonsoft.Json;
using Proyecto_final_Herramientas.Helpers;
using Proyecto_final_Herramientas.Helpers.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_final_Herramientas.Interfaces
{
    public class ManejoProductoInterfaz : Form
    {
        public List<Producto> _productos;

        public ManejoProductoInterfaz()
        {
            if (Settings.Productos != "")
            {
                _productos = JsonConvert.DeserializeObject<List<Producto>>(Settings.Productos);
            }
            else
            {
                _productos = new List<Producto>();
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            var productoEncontrado = false;
            for (var p = 0; p < _productos.Count; p++)
            {
                if (_productos[p].Id == producto.Id)
                {
                    _productos[p].Valor = producto.Valor;
                    productoEncontrado = true;
                    _productos[p].Cantidad = producto.Cantidad;
                    productoEncontrado = true;
                    break;
                }
            }

            if (!productoEncontrado)
            {
                _productos.Add(producto);
            }

            Settings.Productos = JsonConvert.SerializeObject(_productos);

        }

        public void EliminarProducto(string idProducto)
        {
            try
            {
                var auxProducto = _productos.FirstOrDefault(p => p.Id == idProducto);
                if (auxProducto != null)
                {
                    _productos.Remove(auxProducto);
                    Settings.Productos = JsonConvert.SerializeObject(_productos);
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
