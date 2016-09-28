namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.PrincipalView
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this._dateTime = new System.Windows.Forms.Timer(this.components);
            this.footStatus = new System.Windows.Forms.StatusStrip();
            this.txtDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfigItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NpcConfigItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConfigNpcGerar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemConfigNpcCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.footStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dateTime
            // 
            this._dateTime.Tick += new System.EventHandler(this._dateTime_Tick);
            // 
            // footStatus
            // 
            this.footStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDateTime});
            this.footStatus.Location = new System.Drawing.Point(0, 482);
            this.footStatus.Name = "footStatus";
            this.footStatus.Size = new System.Drawing.Size(773, 22);
            this.footStatus.SizingGrip = false;
            this.footStatus.Stretch = false;
            this.footStatus.TabIndex = 0;
            this.footStatus.Text = "statusStrip1";
            // 
            // txtDateTime
            // 
            this.txtDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtDateTime.Font = new System.Drawing.Font("Yu Gothic Medium", 9F);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(0, 17);
            this.txtDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // ConfigItem
            // 
            this.ConfigItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfigItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConfigItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NpcConfigItem});
            this.ConfigItem.Name = "ConfigItem";
            this.ConfigItem.Size = new System.Drawing.Size(91, 20);
            this.ConfigItem.Text = "Configuração";
            // 
            // NpcConfigItem
            // 
            this.NpcConfigItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConfigNpcGerar,
            this.ItemConfigNpcCadastrar});
            this.NpcConfigItem.Name = "NpcConfigItem";
            this.NpcConfigItem.Size = new System.Drawing.Size(152, 22);
            this.NpcConfigItem.Text = "NPC";
            // 
            // itemConfigNpcGerar
            // 
            this.itemConfigNpcGerar.Name = "itemConfigNpcGerar";
            this.itemConfigNpcGerar.Size = new System.Drawing.Size(180, 22);
            this.itemConfigNpcGerar.Text = "Gerar";
            this.itemConfigNpcGerar.Click += new System.EventHandler(this.geradorToolStripMenuItem_Click);
            // 
            // ItemConfigNpcCadastrar
            // 
            this.ItemConfigNpcCadastrar.Name = "ItemConfigNpcCadastrar";
            this.ItemConfigNpcCadastrar.Size = new System.Drawing.Size(180, 22);
            this.ItemConfigNpcCadastrar.Text = "Consultar/Cadastrar";
            this.ItemConfigNpcCadastrar.Click += new System.EventHandler(this.ItemConfigNpcCadastrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 504);
            this.Controls.Add(this.footStatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "With You Destiny Generator";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.footStatus.ResumeLayout(false);
            this.footStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _dateTime;
        private System.Windows.Forms.StatusStrip footStatus;
        private System.Windows.Forms.ToolStripStatusLabel txtDateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfigItem;
        private System.Windows.Forms.ToolStripMenuItem NpcConfigItem;
        private System.Windows.Forms.ToolStripMenuItem itemConfigNpcGerar;
        private System.Windows.Forms.ToolStripMenuItem ItemConfigNpcCadastrar;
    }
}