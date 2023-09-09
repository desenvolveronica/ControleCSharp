using Controle_c_.masterDataSetTableAdapters;
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
       
        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente(); //ao clicar no btn cliente eu estou instanciando o formulário
            cliente.TopLevel = false; //aqui falo que ele não será topo
            cliente.Dock = DockStyle.Fill; //aqui falo que ele preencherá o meio 
            PanelCentral.Controls.Clear(); //limpa o painel
            PanelCentral.Controls.Add(cliente);//adiciona o form no painel
            cliente.Show();//para aparecer o formulário

            //aplica a posição do eixo Y do botão ao panel seleção

            panelSelecao.Top = btnClientes.Top;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmCadAnimal animais = new frmCadAnimal();
            animais.TopLevel = false;
            animais.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(animais);
            animais.Show();

            //aplica a posição do eixo Y do botão ao panel seleção
            panelSelecao.Top = btnAnimais.Top;


        }

        private void btnRacas_Click(object sender, EventArgs e)
        {   //aplica a posição do eixo Y do botão ao panel seleção
            panelSelecao.Top = btnRacas.Top;
           
            frmCadRaca racas = new frmCadRaca();
            racas.TopLevel = false;
            racas.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(racas);
            racas.Show();
        }
        private void btnServicos_Click(object sender, EventArgs e)
        {   //aplica a posição do eixo Y do botão ao panel seleção
            panelSelecao.Top = btnServicos.Top;
            frmCadServico servicos = new frmCadServico();
            servicos.TopLevel = false;
            servicos.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(servicos);
            servicos.Show();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {   //aplica a posição do eixo Y do botão ao panel seleção
            panelSelecao.Top = btnAgendamentos.Top;

            frmCadAgendamento agendamento = new frmCadAgendamento();
            agendamento.TopLevel = false;
            agendamento.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(agendamento);
            agendamento.Show();
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Deseja mesmo sair?", "Controle c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {   //Minimizar 
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear(); //limpa o painel para configurar o início
            //aplica a posição do eixo Y do botão ao panel seleção
            panelSelecao.Top = btnHome.Top;
            PanelCentral.Controls.Clear();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {   //maximizar 
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_DetalhesAgendamentos'. Você pode movê-la ou removê-la conforme necessário.
            //this.view_DetalhesAgendamentosTableAdapter.Fill(this.masterDataSet.View_DetalhesAgendamentos);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_ServicosAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            //this.view_ServicosAgendamentoTableAdapter.Fill(this.masterDataSet.View_ServicosAgendamento);
            //ESTÁ CARREGANDO OS DADOS NO TIME ABAIXO (timer1_Tick)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //recarregar os dados na view
            view_DetalhesAgendamentosTableAdapter.Fill(masterDataSet.View_DetalhesAgendamentos);
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Em Andamento'";
            //FILTER EQUIVALE A CLAUSULA WHERE DO SQL
            int qtdAndamento = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());
            view_DetalhesAgendamentosBindingSource.RemoveFilter(); //retirou o filtro anterior
            lblAndamento.Text = qtdAndamento.ToString();

            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Agendado'";
            int qtdAgendado = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());
            view_DetalhesAgendamentosBindingSource.RemoveFilter(); //retirou o filtro anterior
            lblAgandado.Text = qtdAgendado.ToString();

        }

       
    }
}
