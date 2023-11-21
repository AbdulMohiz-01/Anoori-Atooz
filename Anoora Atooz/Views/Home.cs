


using Anoora_Atooz.Views;

namespace Anoora_Atooz
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // code to execute when form is maximized
                this.Hide();
                Product productForm = new Product();
                productForm.Show();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                // code to execute when form is in normal state
                this.Show();
            }
        }
    }
}