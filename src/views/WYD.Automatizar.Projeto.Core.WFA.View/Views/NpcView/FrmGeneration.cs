using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WYD.Automatizar.Projeto.Core.WFA.View.Views.PrincipalView;

namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.NpcView
{
    public partial class FrmGeneration : Form
    {
        private readonly Principal _frmPrincipal;
        private readonly NpcGeneration _npcGeneration;

        public FrmGeneration(Principal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            _npcGeneration = new NpcGeneration();
            InitializeComponent();
        }
        private void FrmGeneration_Load(object sender, EventArgs e)
        {
            statusProgress.Maximum = 100;

        }

        private void FrmGeneration_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmPrincipal.Show();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var caminho = txtCaminho.Text;

            if (ValidarCampo(caminho) && VerificarDiretorio(caminho))
            {
                txtCaminho.Enabled = false;
                btnGerar.Hide();
                _npcGeneration.IniciarVerificação(caminho);
            }
        }

        private bool VerificarDiretorio(string caminho)
        {
            if (File.Exists(caminho) && caminho.EndsWith(".txt"))
                return true;

            lblStatus.Text = @"algo está errado!";
            return false;

        }

        private bool ValidarCampo(string caminho)
        {
            if (!string.IsNullOrEmpty(caminho)) return true;
            txtCaminho.BackColor = Color.Tomato;
            lblStatus.Text = @"Preenha este campo";
            return false;
        }

        private void txtCaminho_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCaminho.BackColor = Color.Empty;
            lblStatus.Text = string.Empty;
        }
    }
}
