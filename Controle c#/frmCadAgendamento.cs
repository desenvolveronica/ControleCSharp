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
    public partial class frmCadAgendamento : Form
    {
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void agendamentoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void agendamentoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.Validate();//VALIDA OS DADOS
                this.agendamentoBindingSource.EndEdit();//FINALIZA EDIÇÃO
                this.tableAdapterManager.UpdateAll(this.masterDataSet);
                groupBox1.Enabled = false;
                MessageBox.Show("Salvo com sucesso");
            }
            catch (Exception)
            { //captura o erro
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }

        }

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.masterDataSet.servico);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_ServicosAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.view_ServicosAgendamentoTableAdapter.Fill(this.masterDataSet.View_ServicosAgendamento);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.masterDataSet.animal);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.agendamento_servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamento_servicosTableAdapter.Fill(this.masterDataSet.agendamento_servicos);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.masterDataSet.agendamento);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ag_situacaoComboBox.Text = "AGENDADO";
            ag_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            ag_horarioMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            ag_totalTextBox.Text = "0,00";
            groupBox1.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            agendamentoBindingSource.CancelEdit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você quer mesmo excluir este registro?", "PetShop2023", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agendamentoTableAdapter.Update(masterDataSet.agendamento); //salva
                    agendamentoBindingSource.RemoveCurrent(); //removeu 
                    MessageBox.Show("Excluido com sucesso!");
                }

            }
            catch (Exception) //captura o erro
            {   //erro pode acontecer caso tentemos excluir um dado que está sendo usado em outra parte do código
                //exemplo: usuário que tem registro de pet 
                agendamentoTableAdapter.Fill(masterDataSet.agendamento); //coloca os dados novamente pois removeu de forma temporária
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

       
    }
}
