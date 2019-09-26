using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscripcionesUniversidad
{
    public partial class Form1 : Form
    {
        ClsDatosBasicos DatosBasicos = new ClsDatosBasicos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatosBasicos.Apellidos1 = txtbApellidosE.Text;
                DatosBasicos.Correo1 = txtbEmail.Text;
                DatosBasicos.Edad1 = Convert.ToInt32(txtbEdad.Text);
                DatosBasicos.Nombre1 = txtbNombreE.Text;
                DatosBasicos.Documento1 = txtbNumeroID.Text;
                DatosBasicos.Telefono1 = txtbTelefono.Text;

            }
            catch (Exception)
            {
                MessageBox.Show("Llene los campos correctamente");
                   
            }
            


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtbTelefono.Clear();
            txtbNumeroID.Clear();
            txtbNombreE.Clear();
            txtbEmail.Clear();
            txtbEdad.Clear();
            txtbApellidosE.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
