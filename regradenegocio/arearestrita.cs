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
        // Cotacao myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Cotacao
        {
            public USDBRL USDBRL { get; set; }
        }

        public class USDBRL
        {
            public string code { get; set; }
            public string codein { get; set; }
            public string name { get; set; }
            public string high { get; set; }
            public string low { get; set; }
            public string varBid { get; set; }
            public string pctChange { get; set; }
            public string bid { get; set; }
            public string ask { get; set; }
            public string timestamp { get; set; }
            public string create_date { get; set; }
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/USD-BRL");
            Cotacao cotacao = JsonConvert.DeserializeObject<Cotacao>(content);
            lstDolar.Items.Add(cotacao.USDBRL.high);
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
        
        public class BRLUSD
        {
            public string code { get; set; }
            public string codein { get; set; }
            public string name { get; set; }
            public string high { get; set; }
            public string low { get; set; }
            public string varBid { get; set; }
            public string pctChange { get; set; }
            public string bid { get; set; }
            public string ask { get; set; }
            public string timestamp { get; set; }
            public string create_date { get; set; }
        }

        public class Conversao
        {
            public BRLUSD BRLUSD { get; set; }
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
            Conversao conversao = JsonConvert.DeserializeObject<Conversao>(content);
            lstReal.Items.Add(conversao.BRLUSD.high);
        }

        
        public class CurrentWeather
        {
            public double temperature { get; set; }
            public double windspeed { get; set; }
            public double winddirection { get; set; }
            public int weathercode { get; set; }
            public int is_day { get; set; }
            public string time { get; set; }
        }

        public class Hourly
        {
            public List<string> time { get; set; }
            public List<double> temperature_2m { get; set; }
            public List<int> relativehumidity_2m { get; set; }
            public List<double> windspeed_10m { get; set; }
        }

        public class HourlyUnits
        {
            public string time { get; set; }
            public string temperature_2m { get; set; }
            public string relativehumidity_2m { get; set; }
            public string windspeed_10m { get; set; }
        }

        public class Temperatura
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double generationtime_ms { get; set; }
            public int utc_offset_seconds { get; set; }
            public string timezone { get; set; }
            public string timezone_abbreviation { get; set; }
            public double elevation { get; set; }
            public CurrentWeather current_weather { get; set; }
            public HourlyUnits hourly_units { get; set; }
            public Hourly hourly { get; set; }
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var content = client.DownloadString("https://api.open-meteo.com/v1/forecast?latitude=-23.493106&longitude=-46.6249115&current_weather=true&hourly=temperature_2m,relativehumidity_2m,windspeed_10m");
            Temperatura temperatura = JsonConvert.DeserializeObject<Temperatura>(content);
            this.(temperatura.current_weather.temperature);
        }
    }
}
