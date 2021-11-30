using Microsoft.AspNetCore.Mvc;
using MVC_EF_Start.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace MVC_EF_Start.Controllers
{
    public class HomeController : Controller
    {

        HttpClient httpClient;

        static string BASE_URL = "https://api.open.fec.gov/v1/committees/?sort_hide_null=false&page=1&per_page=20&api_key=";
        static string API_KEY = "fZn1U5g0yNRjFfXNiDUs6oX0ciYldCwYSffwpJVD"; //Add your API key here inside ""

        //static string BASE_URL = "https://data.cdc.gov/api/views/hk9y-quqm/rows.json";
        // Obtaining the API key is easy. The same key should be usable across the entire
        // data.gov developer network, i.e. all data sources on data.gov.
        // https://www.nps.gov/subjects/developer/get-started.html


        public IActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string NATIONAL_PARK_API_PATH = BASE_URL; // + "/parks?limit=20";
            string parksData = "";

            Parks parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH)
                                                        .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                //                                        .GetAwaiter().GetResult();



                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Parks>(parksData);
                }

                //  dbContext.Parks.Add(parks);
                // await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(parks);
        }


        public IActionResult aboutus()
        {
          
            return View();
        }

        public IActionResult candidatemaster()
        {

            return View();
        }

        public IActionResult committeetocandidate()
        {

            return View();
        }

        public IActionResult contributionbyind()
        {

            return View();
        }

        public IActionResult donutchart()
        {

            return View();
        }

    }
}






