using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regradenegocio
{
    public partial class arearestrita : Form
    {
        public arearestrita()
        {
            InitializeComponent();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lstHoras.Items.Add(now.ToString("HH:mm:ss"));
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lstDia.Items.Add(now.ToString("dd/MM/yyyy"));
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/USD-BRL");
            lstDolar.Items.Add(content);
        
        }

        private void btnCep_Click(object sender, EventArgs e)
        {

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
            if (cep.Length < 8) { return; }
            string url = "https://viacep.com.br/ws/" + cep + "/json/";
            WebClient client = new WebClient();
            String resultado = client.DownloadString(url);
            Root endereco = JsonConvert.DeserializeObject<Root>
                (resultado);
            lstCep.Items.Add(endereco.logradouro);
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
            lstReal.Items.Add(content);
        }
    }
}
