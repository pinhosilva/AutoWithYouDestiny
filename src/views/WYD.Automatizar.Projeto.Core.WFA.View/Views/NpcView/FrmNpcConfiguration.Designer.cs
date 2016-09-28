namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.NpcView
{
    partial class FrmNpcConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNpcConfiguration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDestY = new System.Windows.Forms.TextBox();
            this.txtDestX = new System.Windows.Forms.TextBox();
            this.txtDestWait = new System.Windows.Forms.TextBox();
            this.txtDestRange = new System.Windows.Forms.TextBox();
            this.txtFormation = new System.Windows.Forms.TextBox();
            this.txtRouteType = new System.Windows.Forms.TextBox();
            this.txtMaxNumMob = new System.Windows.Forms.TextBox();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.txtStartWait = new System.Windows.Forms.TextBox();
            this.txtStartRange = new System.Windows.Forms.TextBox();
            this.txtFollower = new System.Windows.Forms.TextBox();
            this.txtMinGroup = new System.Windows.Forms.TextBox();
            this.txtMinuteGenerate = new System.Windows.Forms.TextBox();
            this.txtLeader = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbSearchNpc = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBucarNpc = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbSearchNpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtDestY);
            this.groupBox1.Controls.Add(this.txtDestX);
            this.groupBox1.Controls.Add(this.txtDestWait);
            this.groupBox1.Controls.Add(this.txtDestRange);
            this.groupBox1.Controls.Add(this.txtFormation);
            this.groupBox1.Controls.Add(this.txtRouteType);
            this.groupBox1.Controls.Add(this.txtMaxNumMob);
            this.groupBox1.Controls.Add(this.txtStartY);
            this.groupBox1.Controls.Add(this.txtStartX);
            this.groupBox1.Controls.Add(this.txtStartWait);
            this.groupBox1.Controls.Add(this.txtStartRange);
            this.groupBox1.Controls.Add(this.txtFollower);
            this.groupBox1.Controls.Add(this.txtMinGroup);
            this.groupBox1.Controls.Add(this.txtMinuteGenerate);
            this.groupBox1.Controls.Add(this.txtLeader);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(267, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 32);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 26);
            this.txtId.MaxLength = 4;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(126, 20);
            this.txtId.TabIndex = 30;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtDestY
            // 
            this.txtDestY.Location = new System.Drawing.Point(283, 290);
            this.txtDestY.MaxLength = 4;
            this.txtDestY.Name = "txtDestY";
            this.txtDestY.Size = new System.Drawing.Size(105, 20);
            this.txtDestY.TabIndex = 29;
            this.txtDestY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestY_KeyPress);
            // 
            // txtDestX
            // 
            this.txtDestX.Location = new System.Drawing.Point(283, 258);
            this.txtDestX.MaxLength = 4;
            this.txtDestX.Name = "txtDestX";
            this.txtDestX.Size = new System.Drawing.Size(105, 20);
            this.txtDestX.TabIndex = 28;
            this.txtDestX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestX_KeyPress);
            // 
            // txtDestWait
            // 
            this.txtDestWait.Location = new System.Drawing.Point(283, 225);
            this.txtDestWait.MaxLength = 4;
            this.txtDestWait.Name = "txtDestWait";
            this.txtDestWait.Size = new System.Drawing.Size(105, 20);
            this.txtDestWait.TabIndex = 27;
            this.txtDestWait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestWait_KeyPress);
            // 
            // txtDestRange
            // 
            this.txtDestRange.Location = new System.Drawing.Point(283, 193);
            this.txtDestRange.MaxLength = 4;
            this.txtDestRange.Name = "txtDestRange";
            this.txtDestRange.Size = new System.Drawing.Size(105, 20);
            this.txtDestRange.TabIndex = 26;
            this.txtDestRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestRange_KeyPress);
            // 
            // txtFormation
            // 
            this.txtFormation.Location = new System.Drawing.Point(283, 160);
            this.txtFormation.MaxLength = 4;
            this.txtFormation.Name = "txtFormation";
            this.txtFormation.Size = new System.Drawing.Size(105, 20);
            this.txtFormation.TabIndex = 25;
            this.txtFormation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormation_KeyPress);
            // 
            // txtRouteType
            // 
            this.txtRouteType.Location = new System.Drawing.Point(283, 126);
            this.txtRouteType.MaxLength = 4;
            this.txtRouteType.Name = "txtRouteType";
            this.txtRouteType.Size = new System.Drawing.Size(105, 20);
            this.txtRouteType.TabIndex = 24;
            this.txtRouteType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRouteType_KeyPress);
            // 
            // txtMaxNumMob
            // 
            this.txtMaxNumMob.Location = new System.Drawing.Point(283, 94);
            this.txtMaxNumMob.MaxLength = 4;
            this.txtMaxNumMob.Name = "txtMaxNumMob";
            this.txtMaxNumMob.Size = new System.Drawing.Size(105, 20);
            this.txtMaxNumMob.TabIndex = 23;
            this.txtMaxNumMob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxNumMob_KeyPress);
            // 
            // txtStartY
            // 
            this.txtStartY.Location = new System.Drawing.Point(102, 290);
            this.txtStartY.MaxLength = 4;
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(105, 20);
            this.txtStartY.TabIndex = 22;
            this.txtStartY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartY_KeyPress);
            // 
            // txtStartX
            // 
            this.txtStartX.Location = new System.Drawing.Point(102, 258);
            this.txtStartX.MaxLength = 4;
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(105, 20);
            this.txtStartX.TabIndex = 21;
            this.txtStartX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartX_KeyPress);
            // 
            // txtStartWait
            // 
            this.txtStartWait.Location = new System.Drawing.Point(102, 225);
            this.txtStartWait.MaxLength = 4;
            this.txtStartWait.Name = "txtStartWait";
            this.txtStartWait.Size = new System.Drawing.Size(105, 20);
            this.txtStartWait.TabIndex = 20;
            this.txtStartWait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartWait_KeyPress);
            // 
            // txtStartRange
            // 
            this.txtStartRange.Location = new System.Drawing.Point(102, 193);
            this.txtStartRange.MaxLength = 4;
            this.txtStartRange.Name = "txtStartRange";
            this.txtStartRange.Size = new System.Drawing.Size(105, 20);
            this.txtStartRange.TabIndex = 19;
            this.txtStartRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartRange_KeyPress);
            // 
            // txtFollower
            // 
            this.txtFollower.Location = new System.Drawing.Point(102, 160);
            this.txtFollower.MaxLength = 20;
            this.txtFollower.Name = "txtFollower";
            this.txtFollower.Size = new System.Drawing.Size(105, 20);
            this.txtFollower.TabIndex = 18;
            this.txtFollower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFollower_KeyPress);
            // 
            // txtMinGroup
            // 
            this.txtMinGroup.Location = new System.Drawing.Point(102, 126);
            this.txtMinGroup.MaxLength = 4;
            this.txtMinGroup.Name = "txtMinGroup";
            this.txtMinGroup.Size = new System.Drawing.Size(105, 20);
            this.txtMinGroup.TabIndex = 17;
            this.txtMinGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinGroup_KeyPress);
            // 
            // txtMinuteGenerate
            // 
            this.txtMinuteGenerate.Location = new System.Drawing.Point(102, 94);
            this.txtMinuteGenerate.MaxLength = 4;
            this.txtMinuteGenerate.Name = "txtMinuteGenerate";
            this.txtMinuteGenerate.Size = new System.Drawing.Size(105, 20);
            this.txtMinuteGenerate.TabIndex = 16;
            this.txtMinuteGenerate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuteGenerate_KeyPress);
            // 
            // txtLeader
            // 
            this.txtLeader.Location = new System.Drawing.Point(56, 64);
            this.txtLeader.MaxLength = 20;
            this.txtLeader.Name = "txtLeader";
            this.txtLeader.Size = new System.Drawing.Size(332, 20);
            this.txtLeader.TabIndex = 5;
            this.txtLeader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeader_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(214, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "DestWait";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "DestRange";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "DestY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "DestX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "StartWait";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "StartRange";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "StartY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "StartX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Formation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "RouteType";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Follower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Leader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "MinGroup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MaxNumMob";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Minute Generate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificador";
            // 
            // gpbSearchNpc
            // 
            this.gpbSearchNpc.Controls.Add(this.dataGridView1);
            this.gpbSearchNpc.Location = new System.Drawing.Point(418, 53);
            this.gpbSearchNpc.Name = "gpbSearchNpc";
            this.gpbSearchNpc.Size = new System.Drawing.Size(340, 410);
            this.gpbSearchNpc.TabIndex = 1;
            this.gpbSearchNpc.TabStop = false;
            this.gpbSearchNpc.Text = "Lista de NPC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(687, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 22);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar NPC";
            // 
            // txtBucarNpc
            // 
            this.txtBucarNpc.Location = new System.Drawing.Point(418, 28);
            this.txtBucarNpc.Name = "txtBucarNpc";
            this.txtBucarNpc.Size = new System.Drawing.Size(263, 20);
            this.txtBucarNpc.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(288, 431);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 32);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 32);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(139, 431);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(121, 32);
            this.btnDesativar.TabIndex = 31;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            // 
            // FrmNpcConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 466);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBucarNpc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpbSearchNpc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNpcConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNpcConfiguration_FormClosing);
            this.Load += new System.EventHandler(this.FrmNpcConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbSearchNpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbSearchNpc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBucarNpc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDestY;
        private System.Windows.Forms.TextBox txtDestX;
        private System.Windows.Forms.TextBox txtDestWait;
        private System.Windows.Forms.TextBox txtDestRange;
        private System.Windows.Forms.TextBox txtFormation;
        private System.Windows.Forms.TextBox txtRouteType;
        private System.Windows.Forms.TextBox txtMaxNumMob;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.TextBox txtStartWait;
        private System.Windows.Forms.TextBox txtStartRange;
        private System.Windows.Forms.TextBox txtFollower;
        private System.Windows.Forms.TextBox txtMinGroup;
        private System.Windows.Forms.TextBox txtMinuteGenerate;
        private System.Windows.Forms.TextBox txtLeader;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnDesativar;
    }
}