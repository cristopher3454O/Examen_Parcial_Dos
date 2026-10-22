using System;
using System.ComponentModel;
using System.Data;
using System.Text.Json.Serialization.Metadata;
namespace ExamenDosRegistros
{
    public partial class Form1 : Form
    {
        BindingList<Reserva> reservas = new BindingList<Reserva>();
        BindingList<Taller> tallers = new BindingList<Taller>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void ActualizarLugares()
        {
            Taller lugares = (Taller)cmbTaller.SelectedItem;
            int cantidad = (int)numCantidad.Value;
            lugares.CupoMaximo-=  cantidad;
            lblLugaresDisponibles.Text = "Lugares Disponibles " + lugares.CupoMaximo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tallers.Add(new Taller { Nombre = "Progamación C#", CupoMaximo = 5 });
            tallers.Add(new Taller { Nombre = "Diseño Web", CupoMaximo = 4 });
            tallers.Add(new Taller { Nombre = "Redes Basicas", CupoMaximo = 6 });

            cmbTaller.DataSource = tallers;

            dgvDatos.DataSource = reservas;



        }

        private void cmbTaller_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sacamos lugares Disponibles
            Taller cantidadLugares = (Taller)cmbTaller.SelectedItem;
            ActualizarLugares();



        }

        private void btnReserva_Click(object sender, EventArgs e)
        {

            if (cmbTaller.SelectedItem == null)
            {
                MessageBox.Show("Tienes que selecionar una opcioón", "Opción no selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Tienes que colocar un Nombre", "Nombre Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }



            // Datos a implementar en el constructos más adelante
            Taller tallerSelecionado = (Taller)cmbTaller.SelectedItem;
            int lugares = (int)numCantidad.Value;


   
            bool materia = chbMaterial.Checked;
            string nombre = txtResponsable.Text.ToString();

            string turno = "";

            ActualizarLugares();

;





            // Radios Buttons
            if (rdbMatutino.Checked)
            {
                turno = "Matutino";
            }
            else
            {
                turno = "Vespertino";
            }

            // Material
            bool material = chbMaterial.Checked;

            Reserva nuevaReserva = new Reserva
            {
                Responsable = nombre,
                Taller = tallerSelecionado,
                Cantidad = lugares,
                Turno = turno,
                Material = material
            };


            reservas.Add(nuevaReserva);


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                Reserva ReservaBorrar = (Reserva)dgvDatos.SelectedRows[0].DataBoundItem;
                reservas.Remove(ReservaBorrar);
            }
            else
            {
                MessageBox.Show("Seleciona algo para borrar", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro de elimianr todo?", "Confirmacion eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                reservas.Clear();
            }
        }
    }
}

