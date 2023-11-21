using Anoora_Atooz.Views;

namespace Anoora_Atooz
{
    public partial class Home : Form
    {

        private Product _productForm;
        //private History _historyForm;
        private Invoice _invoiceForm;
        public Home()
        {
            InitializeComponent();
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            _productForm = new Product();
            _productForm.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
             _invoiceForm = new Invoice();
            _invoiceForm.Show();
            this.Hide();
        }
    }
}