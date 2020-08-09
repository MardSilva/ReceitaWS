namespace TesteWsReceita
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.grpCPNJ = new System.Windows.Forms.GroupBox();
            this.msktxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.grpDadosEmpresa = new System.Windows.Forms.GroupBox();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtSituacaoEmpresa = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtDataAbertura = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbllinkGitHub = new System.Windows.Forms.LinkLabel();
            this.Dicas = new System.Windows.Forms.ToolTip(this.components);
            this.grpCPNJ.SuspendLayout();
            this.grpDadosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumo de Dados - Receita Federal (WebServices)";
            // 
            // grpCPNJ
            // 
            this.grpCPNJ.Controls.Add(this.msktxtCNPJ);
            this.grpCPNJ.Controls.Add(this.btnObterDados);
            this.grpCPNJ.Location = new System.Drawing.Point(12, 62);
            this.grpCPNJ.Name = "grpCPNJ";
            this.grpCPNJ.Size = new System.Drawing.Size(882, 106);
            this.grpCPNJ.TabIndex = 1;
            this.grpCPNJ.TabStop = false;
            this.grpCPNJ.Text = "Digite o CNPJ";
            this.Dicas.SetToolTip(this.grpCPNJ, "Neste grupo, você precisará informar o CNPJ para que a consulta seja feita com su" +
        "cesso.");
            // 
            // msktxtCNPJ
            // 
            this.msktxtCNPJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCNPJ.Location = new System.Drawing.Point(202, 45);
            this.msktxtCNPJ.Mask = "00,000,000/0000-00";
            this.msktxtCNPJ.Name = "msktxtCNPJ";
            this.msktxtCNPJ.Size = new System.Drawing.Size(298, 27);
            this.msktxtCNPJ.SkipLiterals = false;
            this.msktxtCNPJ.TabIndex = 0;
            this.msktxtCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Dicas.SetToolTip(this.msktxtCNPJ, "Para obter os dados, digite aqui o CNPJ da empresa desejada!");
            this.msktxtCNPJ.MouseHover += new System.EventHandler(this.msktxtCNPJ_MouseHover);
            // 
            // btnObterDados
            // 
            this.btnObterDados.Location = new System.Drawing.Point(518, 42);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(161, 32);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Obter Dados";
            this.Dicas.SetToolTip(this.btnObterDados, "Clique aqui para buscar os dados da empresa diretamente da Receita Federal.");
            this.btnObterDados.UseVisualStyleBackColor = true;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // grpDadosEmpresa
            // 
            this.grpDadosEmpresa.Controls.Add(this.txtEmailEmpresa);
            this.grpDadosEmpresa.Controls.Add(this.txtNomeEmpresa);
            this.grpDadosEmpresa.Controls.Add(this.txtEnderecoCompleto);
            this.grpDadosEmpresa.Controls.Add(this.txtCEP);
            this.grpDadosEmpresa.Controls.Add(this.txtSituacaoEmpresa);
            this.grpDadosEmpresa.Controls.Add(this.txtUF);
            this.grpDadosEmpresa.Controls.Add(this.txtDataAbertura);
            this.grpDadosEmpresa.Controls.Add(this.txtTelefone);
            this.grpDadosEmpresa.Controls.Add(this.txtCNPJ);
            this.grpDadosEmpresa.Controls.Add(this.lblBairro);
            this.grpDadosEmpresa.Controls.Add(this.label10);
            this.grpDadosEmpresa.Controls.Add(this.lblSituacao);
            this.grpDadosEmpresa.Controls.Add(this.lblCNPJ);
            this.grpDadosEmpresa.Controls.Add(this.label9);
            this.grpDadosEmpresa.Controls.Add(this.lblEmail);
            this.grpDadosEmpresa.Controls.Add(this.label2);
            this.grpDadosEmpresa.Controls.Add(this.lblTelefone);
            this.grpDadosEmpresa.Controls.Add(this.lblNome);
            this.grpDadosEmpresa.Controls.Add(this.label5);
            this.grpDadosEmpresa.Location = new System.Drawing.Point(12, 179);
            this.grpDadosEmpresa.Name = "grpDadosEmpresa";
            this.grpDadosEmpresa.Size = new System.Drawing.Size(882, 272);
            this.grpDadosEmpresa.TabIndex = 2;
            this.grpDadosEmpresa.TabStop = false;
            this.grpDadosEmpresa.Text = "Dados da Empresa";
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Location = new System.Drawing.Point(460, 111);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(416, 25);
            this.txtEmailEmpresa.TabIndex = 3;
            this.Dicas.SetToolTip(this.txtEmailEmpresa, "Neste campo, será exibido o E-mail da Empresa.");
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(460, 78);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(416, 25);
            this.txtNomeEmpresa.TabIndex = 3;
            this.Dicas.SetToolTip(this.txtNomeEmpresa, "Neste campo, será exibido o Nome da Empresa.");
            // 
            // txtEnderecoCompleto
            // 
            this.txtEnderecoCompleto.Location = new System.Drawing.Point(123, 142);
            this.txtEnderecoCompleto.Name = "txtEnderecoCompleto";
            this.txtEnderecoCompleto.Size = new System.Drawing.Size(662, 25);
            this.txtEnderecoCompleto.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtEnderecoCompleto, "Neste campo, será exibido o Endereço Completo da Empresa.");
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(764, 173);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(112, 25);
            this.txtCEP.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtCEP, "Neste campo, será preenchido o CEP do Lograduro da Empresa.");
            // 
            // txtSituacaoEmpresa
            // 
            this.txtSituacaoEmpresa.Location = new System.Drawing.Point(399, 173);
            this.txtSituacaoEmpresa.Name = "txtSituacaoEmpresa";
            this.txtSituacaoEmpresa.Size = new System.Drawing.Size(97, 25);
            this.txtSituacaoEmpresa.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtSituacaoEmpresa, "Neste campo, será exibida a Situação Atual da Empresa.");
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(823, 142);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(53, 25);
            this.txtUF.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtUF, "Neste campo, será exibido a Unidade Federativa.");
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Location = new System.Drawing.Point(123, 173);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.Size = new System.Drawing.Size(204, 25);
            this.txtDataAbertura.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtDataAbertura, "Neste campo, consta a data de abertura da empresa na Receita Federal.");
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(123, 111);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(204, 25);
            this.txtTelefone.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtTelefone, "Neste campo, será exibido o Telefone da Empresa.");
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(123, 78);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(204, 25);
            this.txtCNPJ.TabIndex = 2;
            this.Dicas.SetToolTip(this.txtCNPJ, "Neste campo, será exibido o CNPJ da Empresa.");
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 145);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(66, 17);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "CEP:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(333, 176);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(60, 17);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 81);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(111, 17);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ da Empresa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(791, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "UF:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(333, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(121, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail da Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data de Abertura:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 114);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 17);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(333, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(121, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome da Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dados da Empresa";
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Location = new System.Drawing.Point(759, 457);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(135, 32);
            this.btnLimparDados.TabIndex = 5;
            this.btnLimparDados.Text = "Limpar Dados";
            this.Dicas.SetToolTip(this.btnLimparDados, "Clique aqui para Limpar os dados da Consulta realizada.");
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Criado por:";
            // 
            // lbllinkGitHub
            // 
            this.lbllinkGitHub.AutoSize = true;
            this.lbllinkGitHub.Location = new System.Drawing.Point(81, 465);
            this.lbllinkGitHub.Name = "lbllinkGitHub";
            this.lbllinkGitHub.Size = new System.Drawing.Size(213, 17);
            this.lbllinkGitHub.TabIndex = 4;
            this.lbllinkGitHub.TabStop = true;
            this.lbllinkGitHub.Text = "Eymard Silva (MardSilva) no Github";
            this.lbllinkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkGitHub_LinkClicked);
            // 
            // Dicas
            // 
            this.Dicas.AutomaticDelay = 1000;
            this.Dicas.IsBalloon = true;
            this.Dicas.OwnerDraw = true;
            this.Dicas.ShowAlways = true;
            this.Dicas.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Dicas.ToolTipTitle = "Dicas da Ferramenta";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 500);
            this.Controls.Add(this.lbllinkGitHub);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.grpDadosEmpresa);
            this.Controls.Add(this.grpCPNJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Consumo de Serviço";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpCPNJ.ResumeLayout(false);
            this.grpCPNJ.PerformLayout();
            this.grpDadosEmpresa.ResumeLayout(false);
            this.grpDadosEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCPNJ;
        private System.Windows.Forms.GroupBox grpDadosEmpresa;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.MaskedTextBox msktxtCNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lbllinkGitHub;
        private System.Windows.Forms.TextBox txtEnderecoCompleto;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSituacaoEmpresa;
        private System.Windows.Forms.ToolTip Dicas;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtDataAbertura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}

