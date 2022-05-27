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
    public partial class PreFactura : ManejoProductoInterfaz
    {
        public PreFactura()
        {
            try
            {
                InitializeComponent();
                var datos = DTG_Productos.DataSource as DataTable;

                for (var p = 0; p < _productos.Count; p++)
                {
                    DTG_Productos.Rows.Add(_productos[p].Nombre, $"{_productos[p].Valor}", $"{_productos[p].Cantidad}", $"{_productos[p].ValorTotal}");

                    webBrowser1.DocumentText += $"{_productos[p].Nombre} <br>Valor: {_productos[p].Valor:N2} Cantidad: {_productos[p].Cantidad:N0} <br>";

                }
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
