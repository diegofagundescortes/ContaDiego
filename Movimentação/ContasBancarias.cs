using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimentação
{
    public partial class ContasBancarias : Form
    {
        public ContasBancarias()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            var contaBancaria = new CriarConta();
            contaBancaria.Show();
        }
    }
}
