using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regradenegocio
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            string sobrenome;
            string logradouro;
            string cep;
            DateTime nascimento;
            string login;
            string senha;

            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Digite o Nome", "Nome Vazio",
                    MessageBoxButtons.OK);
                txtNome.Focus();
                return;
            }
            else
            {
                nome = txtNome.Text;
            }

            if (txtSobrenome.Text=="")
            {
                MessageBox.Show("Digite o sobrenome");
                txtSobrenome.Focus();
                return;
            }
            else
            {
                sobrenome = txtSobrenome.Text;
            }

            if (txtLogin.Text=="")
            {
                MessageBox.Show("Digite o login");
                txtLogin.Focus();
                return;
            }
            else
            {
                login = txtLogin.Text;
            }
            

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Digite a senha");
                txtSenha.Focus();
                return;
            }
            else
            {
                senha = txtSenha.Text;
            }

            if (txtCep.Text == "")
            {
                MessageBox.Show("Digite o CEP");
                txtCep.Focus();
                return;
            }
            else
            {
                cep = txtCep.Text;
            }

            if (txtLog.Text == "")
            {
                MessageBox.Show("Digite o logradouro");
                txtLog.Focus();
                return;
            }
            else
            {
                logradouro = txtLog.Text;
            }

            if (dtNascimento.Value > DateTime.Now)
            {
                MessageBox.Show("O nascimento não pode ser uma data futura");
                dtNascimento.Focus();
                return;
            }
            if (( DateTime.Now.Year  - dtNascimento.Value.Year) < 18)
            {
                MessageBox.Show("Só é permitido cadastro de maiores de idade");
            }
            try
            {
                MailAddress emailValido = new MailAddress(txtLogin.Text);
                login = txtLogin.Text;
            }
            catch
            {
                MessageBox.Show("O login é inválido");
                return;
            }
            MessageBox.Show("Parabéns, os dados estão corretos!");
            this.Hide();
            home telaInicio = new home(nome, sobrenome, login);
            telaInicio.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 15; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtSobrenome.MaxLength = 15;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }
        public class Root
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; } 
            public string ddd { get; set; }
            public string siafi { get; set; }
        }
        private void BuscaCep(object sender, EventArgs e)
        {
            string cep = txtCep.Text;
            cep = cep.Replace("-", "").Replace(".", "").Replace("_", "").Replace(",", "");
            if (cep.Length <8) { return; }
            string url = "https://viacep.com.br/ws/" + cep + "/json/";
            MessageBox.Show(url);
            WebClient client = new WebClient();
            String resultado = client.DownloadString(url);
            Root endereco = JsonConvert.DeserializeObject<Root>
                (resultado);
            txtLog.Text = endereco.logradouro;
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

    internal class Root
    {
        internal string logradouro;
    }
}
