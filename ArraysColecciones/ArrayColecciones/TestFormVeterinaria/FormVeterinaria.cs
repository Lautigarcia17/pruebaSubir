using Entidades;
using System.Text;

namespace TestFormVeterinaria
{
    public partial class FormVeterinaria : Form
    {
        private Veterinaria veterinaria;
        public FormVeterinaria()
        {
            InitializeComponent();
            this.veterinaria = new Veterinaria(5);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgrega formAgrega = new FormAgrega();

            formAgrega.ShowDialog();

            if (formAgrega.DialogResult == DialogResult.OK)
            {
                this.veterinaria += formAgrega.mascotita;
                this.CargarListBox();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Mascota mascotaSeleccionada = (Mascota)this.listBox.SelectedItem;

            FormElimina formElimina = new FormElimina(mascotaSeleccionada);

            if (formElimina.ShowDialog() == DialogResult.OK)
            {
                this.veterinaria -= formElimina.mascotita;
                this.CargarListBox();
            }
        }

        private void CargarListBox()
        {
            this.listBox.Items.Clear();

            foreach (Mascota mascota in this.veterinaria.lista)
            {
                this.listBox.Items.Add(mascota);
            }

        }


    }
}