using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
			F_login f_login = new F_login(this);
			f_login.ShowDialog();
		}
=======
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }
>>>>>>> 4af18fbb6338195a4c4d1a87d50a96597e211d13

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
<<<<<<< HEAD


		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			F_criarconta f_criarconta = new F_criarconta(this);
			f_criarconta.ShowDialog();

		}
=======
>>>>>>> 4af18fbb6338195a4c4d1a87d50a96597e211d13
	}
}
