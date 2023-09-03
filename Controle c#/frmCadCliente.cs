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
            
            try //tente
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(masterDataSet.cliente);
                btnLocalizar.Enabled = false;
                MessageBox.Show("Salvo com sucesso");
            }
            catch (Exception) { //captura o erro
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
            
        }

        private void cli_cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            btnLocalizar.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "PetShop2023", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            btnLocalizar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnLocalizar.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você quer mesmo excluir este registro?", "PetShop2023", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent(); //removeu 
                    clienteTableAdapter.Update(masterDataSet.cliente); //salva
                    MessageBox.Show("Excluido com sucesso!");
                }

            }
            catch (Exception) //captura o erro
            {   //erro pode acontecer caso tentemos excluir um dado que está sendo usado em outra parte do código
                //exemplo: usuário que tem registro de pet 
                clienteTableAdapter.Fill(masterDataSet.cliente); //coloca os dados novamente pois removeu de forma temporária
                MessageBox.Show("Registro não pode ser excluído");
            }
           
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png; *.PNG) | *.jpg; *.pgn; *.PNG"; //adiciona o filtro para não pegar qualquer arquivo
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // somente se a pessoa clicar em abrir que ela vai salvar  >> clicou em cancelar ele não faz nada
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel carregar esta imagem", "PetShop2023", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLocalizarCliente localizarCliente = new frmLocalizarCliente();
            localizarCliente.ShowDialog();  
        }
    }
}
