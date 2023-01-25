using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
	public partial class F_criarconta : Form
	{
		DataTable dt = new DataTable();

		public F_criarconta(F_escola f)
		{
			InitializeComponent();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void F_criarconta_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string nome = tb_nomeCompleto.Text;
			string apelido = tb_usename.Text;
			string password = tb_password.Text;

			if (nome == "" || apelido == "" || password == "")
			{
				MessageBox.Show("Preencha todos os campos!");
				tb_nomeCompleto.Focus();
				return;
			}
			string sql = "SELECT * FROM tb_usuarios WHERE username_usuario='" + apelido + "'";
			dt = Database.ConsultaSql(sql);
			if (dt.Rows.Count == 1)
			{
				MessageBox.Show("Username já existente em nosso banco de dados.");
				tb_usename.Focus();
				return;
			}
			else
			{
				string sqlite = "INSERT INTO tb_usuarios VALUES('" + nome + "','" + apelido + "','" + password + "')";

			}

		}
	}
}




