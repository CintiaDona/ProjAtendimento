namespace GuicheAtendimento
{
    partial class Form1
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
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_listarSenha = new System.Windows.Forms.Button();
            this.btn_adcGuiche = new System.Windows.Forms.Button();
            this.btn_chamar = new System.Windows.Forms.Button();
            this.btn_listarAtend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lbl_numGuiches = new System.Windows.Forms.Label();
            this.lst_senhas = new System.Windows.Forms.ListBox();
            this.lst_atendimento = new System.Windows.Forms.ListBox();
            this.nmr_guiche = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_guiche)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(49, 28);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(87, 25);
            this.btn_gerar.TabIndex = 0;
            this.btn_gerar.Text = "Gerar senha";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_listarSenha
            // 
            this.btn_listarSenha.Location = new System.Drawing.Point(36, 167);
            this.btn_listarSenha.Name = "btn_listarSenha";
            this.btn_listarSenha.Size = new System.Drawing.Size(111, 25);
            this.btn_listarSenha.TabIndex = 0;
            this.btn_listarSenha.Text = "Listar senhas";
            this.btn_listarSenha.UseVisualStyleBackColor = true;
            this.btn_listarSenha.Click += new System.EventHandler(this.btn_listarSenha_Click);
            // 
            // btn_adcGuiche
            // 
            this.btn_adcGuiche.Location = new System.Drawing.Point(202, 136);
            this.btn_adcGuiche.Name = "btn_adcGuiche";
            this.btn_adcGuiche.Size = new System.Drawing.Size(120, 25);
            this.btn_adcGuiche.TabIndex = 0;
            this.btn_adcGuiche.Text = "Adicionar guichê";
            this.btn_adcGuiche.UseVisualStyleBackColor = true;
            this.btn_adcGuiche.Click += new System.EventHandler(this.btn_adcGuiche_Click);
            // 
            // btn_chamar
            // 
            this.btn_chamar.Location = new System.Drawing.Point(493, 28);
            this.btn_chamar.Name = "btn_chamar";
            this.btn_chamar.Size = new System.Drawing.Size(126, 25);
            this.btn_chamar.TabIndex = 0;
            this.btn_chamar.Text = "Chamar próxima senha";
            this.btn_chamar.UseVisualStyleBackColor = true;
            this.btn_chamar.Click += new System.EventHandler(this.btn_chamar_Click);
            // 
            // btn_listarAtend
            // 
            this.btn_listarAtend.Location = new System.Drawing.Point(443, 167);
            this.btn_listarAtend.Name = "btn_listarAtend";
            this.btn_listarAtend.Size = new System.Drawing.Size(141, 25);
            this.btn_listarAtend.TabIndex = 0;
            this.btn_listarAtend.Text = "Listar atendimentos";
            this.btn_listarAtend.UseVisualStyleBackColor = true;
            this.btn_listarAtend.Click += new System.EventHandler(this.btn_listarAtend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guichê";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(199, 59);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(133, 14);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "Quantidade de guichês";
            // 
            // lbl_numGuiches
            // 
            this.lbl_numGuiches.AutoSize = true;
            this.lbl_numGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numGuiches.Location = new System.Drawing.Point(245, 89);
            this.lbl_numGuiches.Name = "lbl_numGuiches";
            this.lbl_numGuiches.Size = new System.Drawing.Size(30, 31);
            this.lbl_numGuiches.TabIndex = 2;
            this.lbl_numGuiches.Text = "0";
            // 
            // lst_senhas
            // 
            this.lst_senhas.FormattingEnabled = true;
            this.lst_senhas.ItemHeight = 14;
            this.lst_senhas.Location = new System.Drawing.Point(12, 59);
            this.lst_senhas.Name = "lst_senhas";
            this.lst_senhas.Size = new System.Drawing.Size(170, 102);
            this.lst_senhas.TabIndex = 4;
            // 
            // lst_atendimento
            // 
            this.lst_atendimento.FormattingEnabled = true;
            this.lst_atendimento.ItemHeight = 14;
            this.lst_atendimento.Location = new System.Drawing.Point(351, 59);
            this.lst_atendimento.Name = "lst_atendimento";
            this.lst_atendimento.Size = new System.Drawing.Size(347, 102);
            this.lst_atendimento.TabIndex = 4;
            // 
            // nmr_guiche
            // 
            this.nmr_guiche.Location = new System.Drawing.Point(443, 31);
            this.nmr_guiche.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmr_guiche.Name = "nmr_guiche";
            this.nmr_guiche.Size = new System.Drawing.Size(37, 20);
            this.nmr_guiche.TabIndex = 5;
            this.nmr_guiche.ValueChanged += new System.EventHandler(this.nmr_guiche_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 214);
            this.Controls.Add(this.nmr_guiche);
            this.Controls.Add(this.lst_atendimento);
            this.Controls.Add(this.lst_senhas);
            this.Controls.Add(this.lbl_numGuiches);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listarAtend);
            this.Controls.Add(this.btn_chamar);
            this.Controls.Add(this.btn_adcGuiche);
            this.Controls.Add(this.btn_listarSenha);
            this.Controls.Add(this.btn_gerar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sistema de Atendimento";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_guiche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_listarSenha;
        private System.Windows.Forms.Button btn_adcGuiche;
        private System.Windows.Forms.Button btn_chamar;
        private System.Windows.Forms.Button btn_listarAtend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lbl_numGuiches;
        private System.Windows.Forms.ListBox lst_senhas;
        private System.Windows.Forms.ListBox lst_atendimento;
        private System.Windows.Forms.NumericUpDown nmr_guiche;
    }
}

