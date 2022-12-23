namespace Sistema_CRUD_CSHARP.Interfaces
{
    partial class frm_Novo_Usuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Nova_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Novo_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Criar_Usuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Nova_Senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_Novo_Usuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Criar_Usuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira os seus dados de login";
            // 
            // tbx_Nova_Senha
            // 
            this.tbx_Nova_Senha.Location = new System.Drawing.Point(49, 60);
            this.tbx_Nova_Senha.Name = "tbx_Nova_Senha";
            this.tbx_Nova_Senha.Size = new System.Drawing.Size(193, 20);
            this.tbx_Nova_Senha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // tbx_Novo_Usuario
            // 
            this.tbx_Novo_Usuario.Location = new System.Drawing.Point(68, 31);
            this.tbx_Novo_Usuario.Name = "tbx_Novo_Usuario";
            this.tbx_Novo_Usuario.Size = new System.Drawing.Size(174, 20);
            this.tbx_Novo_Usuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo Login:";
            // 
            // btn_Criar_Usuario
            // 
            this.btn_Criar_Usuario.Location = new System.Drawing.Point(148, 86);
            this.btn_Criar_Usuario.Name = "btn_Criar_Usuario";
            this.btn_Criar_Usuario.Size = new System.Drawing.Size(94, 23);
            this.btn_Criar_Usuario.TabIndex = 0;
            this.btn_Criar_Usuario.Text = "Criar usuário";
            this.btn_Criar_Usuario.UseVisualStyleBackColor = true;
            this.btn_Criar_Usuario.Click += new System.EventHandler(this.btn_Criar_Usuario_Click);
            // 
            // frm_Novo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 150);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Novo_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEM VINDO - Criar novo usuário";
            this.Load += new System.EventHandler(this.frm_Novo_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_Nova_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Novo_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Criar_Usuario;
    }
}