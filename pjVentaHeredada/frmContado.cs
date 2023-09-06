using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaHeredada
{
    public partial class frmContado : Form
    {
        static string[] productos = { "Lavadora", "Refrigeradora", 
            "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };
        public frmContado()
        {
            InitializeComponent();
        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = productos;
            MostrarFecha();
            MostrarHora();
            lblNeto.Text = "0.00";
        }

        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString(); 
        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase contado
            Contado objC = new();

            //Datos del cliente
            objC.Cliente = txtCliente.Text;
            objC.RUC = txtRUC.Text;
            objC.Fecha = DateTime.Parse(lblFecha.Text);
            objC.Hora = DateTime.Parse(lblHora.Text);

            //Datos del producto
            objC.Producto = cboProducto.Text;
            objC.Cantidad = int.Parse(txtCantidad.Text);

            //Imprimiento en la lista
            ListViewItem fila = new ListViewItem(objC.GetN().ToString());
            fila.SubItems.Add(objC.Producto);
            fila.SubItems.Add(objC.Cantidad.ToString());
            fila.SubItems.Add(objC.AsignaPrecio().ToString("C"));
            fila.SubItems.Add(objC.CalculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
        }
    }
}
