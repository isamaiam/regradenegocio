using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regradenegocio
{
    public partial class home : Form
    {
        public home(string nome, string sobrenome, string login )
        {
            InitializeComponent();
            lblNome.Text = nome;
            lblSobrenome.Text = sobrenome;
            lblLogin.Text = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
