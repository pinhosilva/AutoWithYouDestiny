using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WYD.Automatizar.Projeto.Core.WFA.View.Views.PrincipalView;

namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.NpcView
{
    public partial class FrmNpcConfiguration : Form
    {
        private readonly Principal _frmPrincipal;
        public FrmNpcConfiguration(Principal frmPrincipal)
        {
            _frmPrincipal = frmPrincipal;
            InitializeComponent();
        }

        private static bool IsNumber(KeyPressEventArgs e) => !char.IsDigit(e.KeyChar) && e.KeyChar != (char) 8;

        #region Eventos KeyPress
        private void txtMinuteGenerate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtMaxNumMob_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtMinGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtRouteType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtFollower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !IsNumber(e) && e.KeyChar != (char)Keys.Back;
        }
        private void txtLeader_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !IsNumber(e) && e.KeyChar != (char)Keys.Back;
        }
        private void txtFormation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtStartRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtDestRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtStartWait_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtDestWait_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtStartX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtDestX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtStartY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtDestY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        #endregion

        private void FrmNpcConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmPrincipal.Show();
        }

        private void InitForm(bool isInit)
        {
            txtId.Enabled = !isInit;
            txtLeader.Enabled = isInit;
            txtMinuteGenerate.Enabled = isInit;
            txtMinGroup.Enabled = isInit;
            txtFollower.Enabled = isInit;
            txtStartRange.Enabled = isInit;
            txtStartWait.Enabled = isInit;
            txtStartX.Enabled = isInit;
            txtStartY.Enabled = isInit;
            txtMaxNumMob.Enabled = isInit;
            txtRouteType.Enabled = isInit;
            txtFormation.Enabled = isInit;
            txtDestRange.Enabled = isInit;
            txtDestWait.Enabled = isInit;
            txtDestX.Enabled = isInit;
            txtDestY.Enabled = isInit;

            btnNovo.Enabled = !isInit;
            btnExcluir.Enabled = !isInit;
            btnDesativar.Enabled = !isInit;
            btnSalvar.Enabled = isInit;
        }

        private void FrmNpcConfiguration_Load(object sender, EventArgs e)
        {
            InitForm(true);
        }
    }
}
