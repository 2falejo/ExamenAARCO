using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace ExamenAARCO2
{
    public class Cotizamatico
    {

        public string NombreCatalogo2 { get; set; } = string.Empty;
        public string Filtro2 { get; set; } = string.Empty;
        public int IdAplication2 { get; set; }

        public async Task <String> consulta()
        {

            var contenido = new contenido {NombreCatalogo=NombreCatalogo2,Filtro=Filtro2,IdAplication=IdAplication2};



            HttpClient client = new HttpClient();

            string url = "https://apitestcotizamatico.azurewebsites.net/api/catalogos";

            var response = await client.PostAsJsonAsync(url, contenido);

            var responsestring = await response.Content.ReadAsStringAsync();


            Console.WriteLine(responsestring);

            return responsestring;

        }


    }
}
