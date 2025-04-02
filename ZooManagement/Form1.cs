using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZooManagement.Modelos;

namespace ZooManagement
{
    public partial class Form1 : Form
    {
        private List<Animal> animales = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            cmbTipoAnimal.Items.Add("León");
            cmbTipoAnimal.Items.Add("Elefante");
            cmbTipoAnimal.Items.Add("Serpiente");
            cmbTipoAnimal.SelectedIndex = 0;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipoAnimal.SelectedItem.ToString();
            string nombre = txtNombre.Text;

            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0)
            {
                MessageBox.Show("Edad inválida. Introduzca un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Animal nuevoAnimal = AnimalFactory.CrearAnimal(tipo, nombre, edad);
            animales.Add(nuevoAnimal);

            lstAnimales.Items.Add($"{nuevoAnimal.Nombre} ({tipo}) - {nuevoAnimal.Edad} años");

            txtNombre.Clear();
            txtEdad.Clear();
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            if (lstAnimales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un animal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Animal animalSeleccionado = animales[lstAnimales.SelectedIndex];
            MessageBox.Show(animalSeleccionado.HacerSonido(), "Sonido del Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
