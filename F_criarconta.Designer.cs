namespace WindowsFormsApp2
{
	partial class F_criarconta
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
			this.tb_nomeCompleto = new System.Windows.Forms.TextBox();
			this.tb_usename = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cb_ativado = new System.Windows.Forms.CheckBox();
			this.cb_desativado = new System.Windows.Forms.CheckBox();
			this.cb_aluno = new System.Windows.Forms.CheckBox();
			this.cb_inspetor = new System.Windows.Forms.CheckBox();
			this.cb_coordenador = new System.Windows.Forms.CheckBox();
			this.cb_professor = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(118, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Novo usuário";
			// 
			// tb_nomeCompleto
			// 
			this.tb_nomeCompleto.Location = new System.Drawing.Point(12, 105);
			this.tb_nomeCompleto.Name = "tb_nomeCompleto";
			this.tb_nomeCompleto.Size = new System.Drawing.Size(394, 20);
			this.tb_nomeCompleto.TabIndex = 1;
			// 
			// tb_usename
			// 
			this.tb_usename.Location = new System.Drawing.Point(12, 156);
			this.tb_usename.Name = "tb_usename";
			this.tb_usename.Size = new System.Drawing.Size(394, 20);
			this.tb_usename.TabIndex = 2;
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(12, 204);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(394, 20);
			this.tb_password.TabIndex = 3;
			this.tb_password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome completo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Username";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 241);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Status Usuário";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 293);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Nível usuário";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(92, 384);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Criar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(240, 384);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cb_ativado
			// 
			this.cb_ativado.AutoSize = true;
			this.cb_ativado.Location = new System.Drawing.Point(15, 257);
			this.cb_ativado.Name = "cb_ativado";
			this.cb_ativado.Size = new System.Drawing.Size(62, 17);
			this.cb_ativado.TabIndex = 13;
			this.cb_ativado.Text = "Ativado";
			this.cb_ativado.UseVisualStyleBackColor = true;
			// 
			// cb_desativado
			// 
			this.cb_desativado.AutoSize = true;
			this.cb_desativado.Location = new System.Drawing.Point(92, 257);
			this.cb_desativado.Name = "cb_desativado";
			this.cb_desativado.Size = new System.Drawing.Size(80, 17);
			this.cb_desativado.TabIndex = 14;
			this.cb_desativado.Text = "Desativado";
			this.cb_desativado.UseVisualStyleBackColor = true;
			// 
			// cb_aluno
			// 
			this.cb_aluno.AutoSize = true;
			this.cb_aluno.Location = new System.Drawing.Point(15, 321);
			this.cb_aluno.Name = "cb_aluno";
			this.cb_aluno.Size = new System.Drawing.Size(53, 17);
			this.cb_aluno.TabIndex = 15;
			this.cb_aluno.Text = "Aluno";
			this.cb_aluno.UseVisualStyleBackColor = true;
			// 
			// cb_inspetor
			// 
			this.cb_inspetor.AutoSize = true;
			this.cb_inspetor.Location = new System.Drawing.Point(92, 321);
			this.cb_inspetor.Name = "cb_inspetor";
			this.cb_inspetor.Size = new System.Drawing.Size(113, 17);
			this.cb_inspetor.TabIndex = 16;
			this.cb_inspetor.Text = "Inspetor de alunos";
			this.cb_inspetor.UseVisualStyleBackColor = true;
			// 
			// cb_coordenador
			// 
			this.cb_coordenador.AutoSize = true;
			this.cb_coordenador.Location = new System.Drawing.Point(223, 321);
			this.cb_coordenador.Name = "cb_coordenador";
			this.cb_coordenador.Size = new System.Drawing.Size(87, 17);
			this.cb_coordenador.TabIndex = 17;
			this.cb_coordenador.Text = "Coordenador";
			this.cb_coordenador.UseVisualStyleBackColor = true;
			// 
			// cb_professor
			// 
			this.cb_professor.AutoSize = true;
			this.cb_professor.Location = new System.Drawing.Point(326, 321);
			this.cb_professor.Name = "cb_professor";
			this.cb_professor.Size = new System.Drawing.Size(70, 17);
			this.cb_professor.TabIndex = 18;
			this.cb_professor.Text = "Professor";
			this.cb_professor.UseVisualStyleBackColor = true;
			// 
			// F_criarconta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 439);
			this.Controls.Add(this.cb_professor);
			this.Controls.Add(this.cb_coordenador);
			this.Controls.Add(this.cb_inspetor);
			this.Controls.Add(this.cb_aluno);
			this.Controls.Add(this.cb_desativado);
			this.Controls.Add(this.cb_ativado);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.tb_usename);
			this.Controls.Add(this.tb_nomeCompleto);
			this.Controls.Add(this.label1);
			this.Name = "F_criarconta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "F_criarconta";
			this.Load += new System.EventHandler(this.F_criarconta_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_nomeCompleto;
		private System.Windows.Forms.TextBox tb_usename;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox cb_ativado;
		private System.Windows.Forms.CheckBox cb_desativado;
		private System.Windows.Forms.CheckBox cb_aluno;
		private System.Windows.Forms.CheckBox cb_inspetor;
		private System.Windows.Forms.CheckBox cb_coordenador;
		private System.Windows.Forms.CheckBox cb_professor;
	}
}