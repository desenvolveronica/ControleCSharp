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
    public partial class frmLocalizarAnimal : Form
    {
        public frmLocalizarAnimal()
        {
            InitializeComponent();
        }

        private void frmLocalizarAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_AnimaisClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AnimaisClientesTableAdapter.Fill(this.masterDataSet.View_AnimaisClientes);

        }
    }
}
