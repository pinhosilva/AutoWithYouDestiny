namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.NpcView
{
    partial class FrmGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneration));
            this.lblNpcGener = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.gbSelecionar = new System.Windows.Forms.GroupBox();
            this.statusProgress = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbSelecionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNpcGener
            // 
            this.lblNpcGener.AutoSize = true;
            this.lblNpcGener.Location = new System.Drawing.Point(12, 22);
            this.lblNpcGener.Name = "lblNpcGener";
            this.lblNpcGener.Size = new System.Drawing.Size(58, 13);
            this.lblNpcGener.TabIndex = 0;
            this.lblNpcGener.Text = "NPCGener";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(15, 38);
            this.txtCaminho.MaxLength = 100;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(318, 20);
            this.txtCaminho.TabIndex = 1;
            this.txtCaminho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaminho_KeyPress);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(258, 64);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // gbSelecionar
            // 
            this.gbSelecionar.Controls.Add(this.txtCaminho);
            this.gbSelecionar.Controls.Add(this.btnGerar);
            this.gbSelecionar.Controls.Add(this.lblNpcGener);
            this.gbSelecionar.Location = new System.Drawing.Point(10, 10);
            this.gbSelecionar.Name = "gbSelecionar";
            this.gbSelecionar.Size = new System.Drawing.Size(339, 94);
            this.gbSelecionar.TabIndex = 3;
            this.gbSelecionar.TabStop = false;
            this.gbSelecionar.Text = "Selecionar";
            // 
            // statusProgress
            // 
            this.statusProgress.Location = new System.Drawing.Point(10, 133);
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(339, 23);
            this.statusProgress.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // FrmGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 167);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.statusProgress);
            this.Controls.Add(this.gbSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeneration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC Generation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGeneration_FormClosing);
            this.gbSelecionar.ResumeLayout(false);
            this.gbSelecionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNpcGener;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox gbSelecionar;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ProgressBar statusProgress;
    }
}