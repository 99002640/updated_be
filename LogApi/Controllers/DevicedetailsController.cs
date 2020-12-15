using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
//using System.Web.Http;
//using System.Web.Mvc;
using LogApi.VM;

namespace LogApi.Controllers
{
    [RoutePrefix("Api/DeviceDetail")]

    public class DevicedetailsController : ApiController
    {

        [Route("desc")]
        [HttpPost]
        // GET: Site
        public async Task<HttpResponseMessage> Index(Desc ds)

        {
            string url = $"https://adopteriotwebapi.eaton.com/api/v1/devices/{ds.id}";

            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ds.Token);

                HttpResponseMessage res = await client.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    return res;
                }
                else
                    return null;

            }
        }
    }
}