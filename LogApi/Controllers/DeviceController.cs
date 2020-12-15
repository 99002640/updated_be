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

    [RoutePrefix("Api/Device")]

    public class DeviceController : ApiController
    {

        [Route("details")]
        [HttpPost]
        // GET: Site
        public async Task<HttpResponseMessage> Index(Device dv)

        {
            string url = $"https://adopteriotwebapi.eaton.com/api/v1/sites/{dv.id}/devices?recursive=true&includeDetail=true";
            
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", dv.Token);

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