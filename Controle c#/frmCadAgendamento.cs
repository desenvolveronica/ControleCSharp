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
                MessageBox.Show("Agendamento salvo, insira o serviço abaixo", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodServ.Focus();
            }
            catch (Exception)
            { //captura o erro
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
            Finalizado();

        }

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_TotalServicos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_TotalServicosTableAdapter.Fill(this.masterDataSet.View_TotalServicos);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_TotalServicos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_TotalServicosTableAdapter.Fill(this.masterDataSet.View_TotalServicos);
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
            Total();
        }

      

        private void txtCodServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodServ.Text != "")
            {
                MessageBox.Show("enter");
            }
        }

        private void txtCodServ_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodServ.Text != "")
            {
                servicoBindingSource.MoveFirst(); //moveu para o primeiro registro
                servicoBindingSource.Filter = "serv_codigo = " + txtCodServ.Text;
                if(servicoBindingSource.Count == 1) //encontrou 1 registro
                {
                    //cria uma variável com todos os dados do registro encontrado
                    DataRowView ServicoEncontrado = (DataRowView)servicoBindingSource.Current; //variavel do tipo array ou matriz
                    txtServico.Text = ServicoEncontrado["serv_descricao"].ToString();
                    txtValorUnit.Text = ServicoEncontrado["serv_preco"].ToString();
                    txtQtd.Text = "1";
                    txtQtd.SelectAll();
                    txtQtd.Focus();
                }
                else  //abrir o cadastro pra ele localizar
                {
                    frmCadServico serv = new frmCadServico();
                    serv.ShowDialog();
                    //jogar os valores para as textBox
                }
               // MessageBox.Show("enter");
            }
        }

        private void btnAddServ_Click(object sender, EventArgs e)
        {
            try
            {
                agendamento_servicosTableAdapter.InserirServico(int.Parse(ag_codigoTextBox.Text), int.Parse(txtCodServ.Text),
               int.Parse(txtQtd.Text), decimal.Parse(txtValorUnit.Text));
                //atualizar a grid
                Atualizar_grid();
                //limpar tudo 
                txtCodServ.Clear();
                txtQtd.Clear();
                txtValorUnit.Clear();
                txtServico.Clear();
                txtCodServ.Focus();
            } catch (Exception)
            {
                MessageBox.Show("Tente Novamente");
            }
            Total();
        }

        private void Atualizar_grid()
        {
            try
            {
                if (ag_codigoTextBox.Text != "") //pesquisa
                {
                    //recarrega os dados
                    view_ServicosAgendamentoTableAdapter.Fill(masterDataSet.View_ServicosAgendamento);
                    //filtra pelo código do agendamento
                    view_ServicosAgendamentoBindingSource.Filter = "ag_serv_agendamento =" + ag_codigoTextBox.Text;
                }
            }
            catch (Exception)
            {

            }
        }

        private void ag_codigoTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_grid();
            Finalizado();
        }


        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQtd.Text != "")
            {
                txtValorUnit.SelectAll();
                txtValorUnit.Focus();
            }
        }

        private void txtValorUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtValorUnit.Text != "")
            {
                btnAddServ_Click(sender, e); //sender e (e) sao valores que tem de referêmcia para o objeto
                //todo objeto precisa desses parâmetros que são argumentos que ele utiliza para funcionar
            }
        }

        private void view_ServicosAgendamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Codigo = 0;
                Codigo = int.Parse(view_ServicosAgendamentoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                agendamento_servicosTableAdapter.RemoverServico(Codigo);
            }catch (Exception)
            { 

            }
            Atualizar_grid();
            Total();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Após finalizado o agendamento não poderá ser alterado", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ag_situacaoComboBox.Text = "Finalizado"; //muda o text da combobox
                agendamentoTableAdapter.Update(masterDataSet.agendamento); //salva as alterações
                MessageBox.Show("Agendamento finalizado com sucesso!", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bloquear se estiver finalizado
                Finalizado();
            }


        }
        private void Finalizado()
        {
            if (ag_situacaoComboBox.Text == "Finalizado")
            {
                agendamentoBindingNavigatorSaveItem.Enabled= false;
                btnCancelar.Enabled= false;
                btnEditar.Enabled= false;
                btnFinalizar.Enabled= false;
                bindingNavigatorDeleteItem.Enabled = false;
                groupBox2.Enabled= false;
            }
            else
            {
                agendamentoBindingNavigatorSaveItem.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnFinalizar.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void agendamentoservicosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Finalizado();
        }

        private void Total()
        {
           
            if (ag_codigoTextBox.Text != "")
            {
                view_TotalServicosTableAdapter.Fill(masterDataSet.View_TotalServicos);
                view_TotalServicosBindingSource.Filter = "ag_serv_agendamento = " + ag_codigoTextBox.Text;
                if (view_TotalServicosBindingSource.Count == 1)
                {
                    //pegar o total e jogar na textBox
                    // DataRowView é uma variável do tipo linha de dados
                    DataRowView Resultado = (DataRowView)view_TotalServicosBindingSource.Current;
                    ag_totalTextBox.Text = Resultado["Total"].ToString();
                    agendamentoTableAdapter.Update(masterDataSet.agendamento);
                }
                else
                {   //se não tiver itens(servicos) o total é = 0,00
                    ag_totalTextBox.Text = "0.00";
                    agendamentoTableAdapter.Update(masterDataSet.agendamento);
                }

            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
