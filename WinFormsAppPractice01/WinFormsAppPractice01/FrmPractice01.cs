namespace Win_Forms_App_Practice_01
{
    public partial class FrmPractice01 : Form
    {
        public FrmPractice01()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNombre.Text);
            MessageBox.Show(numEdad.Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
