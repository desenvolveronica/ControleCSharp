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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try //tente
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterDataSet);
                groupBox1.Enabled = false;
                MessageBox.Show("Salvo com sucesso");
            }
            catch (Exception)
            { //captura o erro
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }


        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.masterDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.masterDataSet.animal);

        }

        private void ani_fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_alergiaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ani_racaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_ani_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos_Ani (*.PNG; *.JPG; *.png; *.jpg) | *.PNG; *.JPG; *.png; *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }catch(Exception)
            {
                MessageBox.Show("Não foi possivel carregar esta imagem", "PetShop2023", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                    animalBindingSource.RemoveCurrent(); //removeu 
                    animalTableAdapter.Update(masterDataSet.animal); //salva
                    MessageBox.Show("Excluido com sucesso!");
                }

            }
            catch (Exception) //captura o erro
            {   //erro pode acontecer caso tentemos excluir um dado que está sendo usado em outra parte do código
                //exemplo: usuário que tem registro de pet 
                animalTableAdapter.Fill(masterDataSet.animal); //coloca os dados novamente pois removeu de forma temporária
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            groupBox1.Enabled=false;
        }
    }
}
