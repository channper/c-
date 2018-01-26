using System;
using System.Collections.Generic;
using System.Text;

namespace App5
{
    class HttpService
    {
        public static async Task<dynamic>
            getDateFormService(string queryString)
        {
            dynamic date = null;
            HttpClient = new HttpClient();
            var response = await client.GetAsync(queryString);

            if((response != null) &&! ((int)response.StatusCode >= 400))
                {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserrializeObject(json);
            }
            return data;
        }
    }
}
