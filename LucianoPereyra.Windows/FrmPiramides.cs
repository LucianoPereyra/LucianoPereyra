namespace LucianoPereyra.Windows
{
    public partial class FrmPiramides : Form
    {
        public FrmPiramides()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtLadoBase.Clear();
            txtAlturaBase.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                var piramide = new PiramideCuadrada(int.Parse(txtLadoBase.Text), int.Parse(txtAlturaBase.Text));

                MessageBox.Show(piramide.InformarDatos(), "Datos de la pirámide", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstPiramides.Items.Add(piramide.InformarLadoYAltura());
                lblCantidad.Text = $"Cantidad de pirámides: {lstPiramides.Items.Count}";

                txtLadoBase.Clear();
                txtAlturaBase.Clear();
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtLadoBase.Text))
            {
                errorProvider1.SetError(txtLadoBase, "El lado de la base no puede estar vacío.");
                valido = false;
            }
            else if (!int.TryParse(txtLadoBase.Text, out int ladoBase) || ladoBase < 0 )
            {
                errorProvider1.SetError(txtLadoBase, "El lado de la base debe ser un número entero positivo.");
                valido = false;
            }

            
            if (string.IsNullOrWhiteSpace(txtAlturaBase.Text))
            {
                errorProvider1.SetError(txtAlturaBase, "La altura de la base no puede estar vacía.");
                valido = false;
            }
            else if (!int.TryParse(txtAlturaBase.Text, out int alturaBase) || alturaBase < 0)
            {
                errorProvider1.SetError(txtAlturaBase, "La altura de la base debe ser un número entero positivo.");
                valido = false;
            }
            return valido;

        }
    }
}
