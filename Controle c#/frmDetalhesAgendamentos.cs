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
    public partial class frmDetalhesAgendamentos : Form
    {
        public frmDetalhesAgendamentos()
        {
            InitializeComponent();
        }

        private void frmDetalhesAgendamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_DetalhesAgendamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_DetalhesAgendamentosTableAdapter.Fill(this.masterDataSet.View_DetalhesAgendamentos);
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "'";

        }

      
    }
}
