using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UniversalComputer
{
    public class ServiceClient
    {
        //frmmain
        internal async static Task<List<string>> GetBrandNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:12292/api/ComputerSales/GetBrandNames/"));
        }

        //frmbrand
        internal async static Task<clsBrand> GetBrandAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsBrand>
                    (await lcHttpClient.GetStringAsync("http://localhost:12292/api/ComputerSales/GetBrand?Name=" + prBrandName));
        }

        internal async static Task<clsOrder> InsertOrderAsync(clsOrder prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsOrder>
                    (await lcHttpClient.GetStringAsync("http://localhost:12292/api/ComputerSales/InsertOrder"));
        }

        internal async static Task<string> DeleteComputerAsync(clsAllComputers prComputers)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
                    ($"http://localhost:12292/api/ComputerSales/DeleteComputer?ComputerName={prComputers.Name}&BrandName={prComputers.BrandName}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
