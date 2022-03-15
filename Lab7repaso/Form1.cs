using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7repaso
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Resumen> resumen = new List<Resumen>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarPropietarios()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.dpi = reader.ReadLine();
                propietario.nombre = reader.ReadLine();
                propietario.apellido = reader.ReadLine();

                propietarios.Add(propietario);
            }

            reader.Close();
        }

        private void CargarPropiedades()
        {
            FileStream stream = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                propiedad.NoCasa = reader.ReadLine();
                propiedad.dpidueno = reader.ReadLine();
                propiedad.Cuota = Convert.ToDecimal(reader.ReadLine());

                propiedades.Add(propiedad);

            }
            reader.Close();

        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = resumen;
            dataGridView1.Refresh();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
