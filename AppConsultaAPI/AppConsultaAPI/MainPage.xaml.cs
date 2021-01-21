using AppConsultaAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppConsultaAPI
{
    public partial class MainPage : ContentPage
    {
        const string urlApi = "http://10.0.0.5:45461/personas";
        readonly HttpClient client = new HttpClient();
        ObservableCollection<PersonaModel> personas;
        string apiContent;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnConsultaAPI_Clicked(object sender, EventArgs e)
        {
            apiContent = await client.GetStringAsync(urlApi);
            List<PersonaModel> getPersonas = JsonConvert.DeserializeObject<List<PersonaModel>>(apiContent);
            personas = new ObservableCollection<PersonaModel>(getPersonas);
            listaPersonas.ItemsSource = personas;
        }
    }
}
