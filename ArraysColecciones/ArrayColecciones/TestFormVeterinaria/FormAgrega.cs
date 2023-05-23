using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormVeterinaria
{
    public partial class FormAgrega : Form
    {
        public Mascota mascotita;
        public FormAgrega()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool vacunado = this.checkBox.Checked;
            this.mascotita = new Mascota(this.txtNombre.Text, int.Parse(this.txtEdad.Text),vacunado);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
