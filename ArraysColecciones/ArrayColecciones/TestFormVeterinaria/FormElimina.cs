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
    public partial class FormElimina : FormAgrega
    {
        public FormElimina()
        {
            InitializeComponent();
        }

        public FormElimina(Mascota m):this()
        {

            this.txtNombre.Text = m.nombre;
            this.txtEdad.Text = m.edad.ToString();
            if (m.vacuna)
            this.checkBox.Checked = true;
            
            this.txtNombre.Enabled = false;
            this.txtEdad.Enabled = false;
            this.checkBox.Enabled = false;
        }

   
    }
}
