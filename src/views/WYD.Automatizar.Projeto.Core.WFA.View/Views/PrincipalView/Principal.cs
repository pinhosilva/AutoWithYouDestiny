using System;
using System.Windows.Forms;
using WYD.Automatizar.Projeto.Core.WFA.View.Views.NpcView;

namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.PrincipalView
{
    public partial class Principal : Form
    {
        private readonly Timer _timer;
        public Principal()
        {
            _timer = new Timer();
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            OnTimer();
        }

        #region DateTime Status
        private void OnTimer()
        {
            _timer.Enabled = true;
            _timer.Interval = 100;
            _timer.Tick += _dateTime_Tick;
        }

        private void _dateTime_Tick(object sender, System.EventArgs e)
        {
            var date = DateTime.Now;
            txtDateTime.Text = string.Empty;
            txtDateTime.Text += $"{date:dd/MM/yyyy}";
            txtDateTime.Text += $" - {date:T} ";
        }
        #endregion

        #region Itens de Configuração
        private void ItemConfigNpcCadastrar_Click(object sender, EventArgs e)
        {
            new FrmNpcConfiguration(this).Show();
            Hide();
        }

        private void geradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGeneration(this).Show();
            Hide();
        }

        #endregion




    }
}
