using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace App5
{
    class HttpService
    {
        public static async Task<dynamic>
            getDateFormService(string queryString)
        {
            dynamic date = null;
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            if((response != null) &&! ((int)response.StatusCode >= 400))
                {
                string json = response.Content.ReadAsStringAsync().Result;
                date = JsonConvert.DeserializeObject(json);
            }
            return date;
        }
    }
}
