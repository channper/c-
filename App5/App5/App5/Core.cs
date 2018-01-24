using System;
using System.Collections.Generic;
using System.Text;

namespace App5
{
    class Core
    {
        public static async Task<dynamic> GetAddressSerchResult (string address)
            {
            string pzNumber = address.Substring(0, 3);
        string taNumber = address.Substring(3);
        string queryString = "http://api.thin.net/jzip/X0401/JSON/" + pzNumber + "/" + taNumber + ".js";
        dynamic results = await HttpService.getDataFormService(queryString).ConfigureAwait(false);

        if((results != null)&&(!string.IsNullOrEmpty((string) results["state"wo])))
        {
        Address Ad = new Address();
        Ad.state = (string) results["state"];
        Ad.stateNmae = (string)results["stateNmae"];
        Ad.city =(string)results["city"];
        Ad.street=(string)results["street"];
        return Ad;
        }
        else
        {
         return null;
        }
      }

    }
}
