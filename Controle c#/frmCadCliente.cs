using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_c_
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void cli_cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
