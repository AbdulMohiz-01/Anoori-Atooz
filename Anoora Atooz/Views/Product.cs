using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anoora_Atooz.Views
{
    public partial class Product : Form
    {
        private Home _home;
        public Product()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _home = new Home();
            _home.Show();
            this.Hide();
        }
    }
}
