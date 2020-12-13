using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEventosyDelegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnValidar.Click += btnValidar_Click;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                string nombres = txtNombres.Text.Trim();
                string apellidoPaterno = txtApellidoPaterno.Text.Trim();
                string apellidoMaterno = txtApellidoMaterno.Text.Trim();
                string fechaNacimiento = txtFechaNacimiento.Text.Trim();

                int contadorVacio = 0;

                if (codigo == string.Empty) { lblCodigo.ForeColor = Color.Red; contadorVacio++; } else { lblCodigo.ForeColor = Color.Black; }
                if (nombres == string.Empty) { lblNombres.ForeColor = Color.Red; contadorVacio++; } else { lblNombres.ForeColor = Color.Black; }
                if (apellidoPaterno == string.Empty) { lblApellidoPaterno.ForeColor = Color.Red; contadorVacio++; } else { lblApellidoPaterno.ForeColor = Color.Black; }
                if (apellidoMaterno == string.Empty) { lblApellidoMaterno.ForeColor = Color.Red; contadorVacio++; } else { lblApellidoMaterno.ForeColor = Color.Black; }
                if (fechaNacimiento == string.Empty) { lblFechaNacimiento.ForeColor = Color.Red; contadorVacio++; } else { lblFechaNacimiento.ForeColor = Color.Black; }

                if (contadorVacio == 0)
                {
                    MessageBox.Show("Formulario validado !");
                }
                else
                {
                    MessageBox.Show("Debes completar los campos marcados en rojo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
