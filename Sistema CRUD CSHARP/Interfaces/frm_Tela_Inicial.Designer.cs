namespace Sistema_CRUD_CSHARP
{
    partial class frm_Tela_Inicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.dgv_Exibir = new System.Windows.Forms.DataGridView();
            this.tbx_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Uf = new System.Windows.Forms.TextBox();
            this.tbx_Cidade = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_Nome = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Exibir = new System.Windows.Forms.Button();
            this.btn_Logoff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exibir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(58, 136);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 1;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // dgv_Exibir
            // 
            this.dgv_Exibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exibir.Location = new System.Drawing.Point(10, 165);
            this.dgv_Exibir.Name = "dgv_Exibir";
            this.dgv_Exibir.Size = new System.Drawing.Size(494, 159);
            this.dgv_Exibir.TabIndex = 2;
            // 
            // tbx_Id
            // 
            this.tbx_Id.Location = new System.Drawing.Point(50, 6);
            this.tbx_Id.Name = "tbx_Id";
            this.tbx_Id.Size = new System.Drawing.Size(45, 20);
            this.tbx_Id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "UF:";
            // 
            // tbx_Uf
            // 
            this.tbx_Uf.Location = new System.Drawing.Point(50, 108);
            this.tbx_Uf.Name = "tbx_Uf";
            this.tbx_Uf.Size = new System.Drawing.Size(45, 20);
            this.tbx_Uf.TabIndex = 8;
            // 
            // tbx_Cidade
            // 
            this.tbx_Cidade.Location = new System.Drawing.Point(50, 82);
            this.tbx_Cidade.Name = "tbx_Cidade";
            this.tbx_Cidade.Size = new System.Drawing.Size(137, 20);
            this.tbx_Cidade.TabIndex = 9;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(50, 56);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(271, 20);
            this.tbx_Email.TabIndex = 10;
            // 
            // tbx_Nome
            // 
            this.tbx_Nome.Location = new System.Drawing.Point(50, 30);
            this.tbx_Nome.Name = "tbx_Nome";
            this.tbx_Nome.Size = new System.Drawing.Size(271, 20);
            this.tbx_Nome.TabIndex = 11;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(139, 136);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(220, 136);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 13;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(301, 136);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 14;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Exibir
            // 
            this.btn_Exibir.Location = new System.Drawing.Point(382, 136);
            this.btn_Exibir.Name = "btn_Exibir";
            this.btn_Exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exibir.TabIndex = 15;
            this.btn_Exibir.Text = "Exibir";
            this.btn_Exibir.UseVisualStyleBackColor = true;
            this.btn_Exibir.Click += new System.EventHandler(this.btn_Exibir_Click_1);
            // 
            // btn_Logoff
            // 
            this.btn_Logoff.ForeColor = System.Drawing.Color.Red;
            this.btn_Logoff.Location = new System.Drawing.Point(321, 330);
            this.btn_Logoff.Name = "btn_Logoff";
            this.btn_Logoff.Size = new System.Drawing.Size(136, 23);
            this.btn_Logoff.TabIndex = 17;
            this.btn_Logoff.Text = "LogOff";
            this.btn_Logoff.UseVisualStyleBackColor = true;
            this.btn_Logoff.Click += new System.EventHandler(this.btn_Logoff_Click);
            // 
            // frm_Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 362);
            this.Controls.Add(this.btn_Logoff);
            this.Controls.Add(this.btn_Exibir);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.tbx_Nome);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_Cidade);
            this.Controls.Add(this.tbx_Uf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Id);
            this.Controls.Add(this.dgv_Exibir);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Tela_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.frm_Tela_Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridView dgv_Exibir;
        private System.Windows.Forms.TextBox tbx_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Uf;
        private System.Windows.Forms.TextBox tbx_Cidade;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_Nome;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Exibir;
        private System.Windows.Forms.Button btn_Logoff;
    }
}