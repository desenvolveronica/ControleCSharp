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
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

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
            openFileDialog1.Filter = "Fotos_Ani (*.PNG; *.JPG; *.png; *.jpg) | *.PNG; *.JPG; *.png; *.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }

            
        }
    }
}
