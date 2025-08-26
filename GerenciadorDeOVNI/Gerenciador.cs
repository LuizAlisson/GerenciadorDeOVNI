using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Gerenciador : Form
    {
        //Objetos globais:
        BibliotecaOVNI.OVNI ovni;

        public Gerenciador(BibliotecaOVNI.OVNI ovni) //Obrigatoriamente deve-se iniciar passando um OVNI
        {
            InitializeComponent();
            //"copiando" o OVNI vindo da outra janela para um obj global:
            this.ovni = ovni;
            //Atualizar informções:
            AtualizarInformacoes();
            //Popular o combox com os planetas validos:
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }
        public void AtualizarInformacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação:  {(ovni.Situacao ? "LIgador" : "Desligado")}";
            lblPlaneta.Text = $"Planeta atual: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;

            //Atualizar os botões ligar e desligar:
            btnLigar.Enabled = ovni.Situacao;
            btnDesligar.Enabled = !ovni.Situacao;
            //Ativar/Desativar o grb de acordo com o status da nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbTripulantes.Enabled= ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O OVNI foi ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está ligado!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Atualizar as informações:
            AtualizarInformacoes();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O OVNI foi Desligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está Desligado!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Atualizar as informações:
            AtualizarInformacoes();
        }

        private void btnAdicionarTripulantes_Click(object sender, EventArgs e)
        {
            if(ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adicionado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A nave ja está lotada de tripulantes!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }
        
    }
}
