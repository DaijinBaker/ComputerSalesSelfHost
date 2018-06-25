using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSalesWinForm
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


        //Computer Insert and Update
        internal async static Task<string> InsertComputersAsync(clsAllComputers prComputers)
        {
            return await InsertOrUpdateAsync(prComputers, "http://localhost:12292/api/ComputerSales/InsertComputer", "POST");
        }

        internal async static Task<string> UpdateComputersAsync(clsAllComputers prComputers)
        {
            return await InsertOrUpdateAsync(prComputers, "http://localhost:12292/api/ComputerSales/UpdateComputer", "PUT");
        }


        //Brand insert
        internal async static Task<string> InsertBrandAsync(clsBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:12292/api/ComputerSales/InsertArtist", "POST");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
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

        //Order
        internal async static Task<object> GetOrderList()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:12292/api/ComputerSales/GetOrderList/"));
        }

    }
}
