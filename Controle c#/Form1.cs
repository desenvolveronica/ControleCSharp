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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo click?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo button1?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRacas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair raças?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
       

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair agendamento?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Deseja mesmo sair sair?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {   //Minimizar 
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
           frmCadCliente cliente = new frmCadCliente(); //ao clicar no btn cliente eu estou instanciando o formulário
            cliente.TopLevel = false; //aqui falo que ele não será topo
            cliente.Dock = DockStyle.Fill; //aqui falo que ele preencherá o meio 
            PanelCentral.Controls.Clear(); //limpa o painel
            PanelCentral.Controls.Add(cliente);//adiciona o form no painel
            cliente.Show();//para aparecer o formulário
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {

        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair sair?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   //maximizar 
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
