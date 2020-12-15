using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc.;
using LogApi.Models;
using LogApi.VM;
using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace LogApi.Controllers
{
    [RoutePrefix("Api/login")]

    public class TokController : ApiController

    {

       [Route("tokdetails")]

        [HttpPost]

        public async Task<HttpResponseMessage> Detail(Tok tk)
        {
            string url = "https://adopteriotwebapi.eaton.com/api/v1/security/tokendetails";
           // string tok = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImtnMkxZczJUMENUaklmajRydDZKSXluZW4zOCIsImtpZCI6ImtnMkxZczJUMENUaklmajRydDZKSXluZW4zOCJ9.eyJhdWQiOiJodHRwczovL2VhdG9uaW90YWRvcHRlcmFkYjJjLm9ubWljcm9zb2Z0LmNvbS9hZG9wdGVyd2ViYXBpc2VydmljZSIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0L2IzY2ZkM2E1LTczMWItNDhlNy1hYTg1LTlhMGUwNTg3MDQ1My8iLCJpYXQiOjE2MDY4ODg1NzMsIm5iZiI6MTYwNjg4ODU3MywiZXhwIjoxNjA2ODkyNDczLCJhY3IiOiIxIiwiYWlvIjoiQVNRQTIvOFJBQUFBZ3BlUUdWcVlpcFFBcFN0Z1ZnS1hWR3Nnczcwd2JTOEh0ZG1tcHZ6cFFLcz0iLCJhbXIiOlsicHdkIl0sImFwcGlkIjoiMTQwNDgwZGQtN2RlNC00NDAxLTkxMGMtMWFlZTM1MTg3NjUzIiwiYXBwaWRhY3IiOiIwIiwiaXBhZGRyIjoiMTY4LjYyLjE2NC4xNDIiLCJuYW1lIjoib3JnYWRtaW4xODExXzFAeW9wbWFpbC5jb20iLCJvaWQiOiI3Zjc2ZTI2Yi00NWEwLTQ3NjMtYjM2Yy03ZDc0ZWZjZmQ2MTYiLCJyaCI6IjAuQUFBQXBkUFBzeHR6NTBpcWhab09CWWNFVTkyQUJCVGtmUUZFa1F3YTdqVVlkbE1WQUc4LiIsInNjcCI6InVzZXJfaW1wZXJzb25hdGlvbiIsInN1YiI6InFjRnJJU0wzS1VOeGVoODFnaU5jb1RqbHV0N3pPR0k4N0hwRGgyODJQR0EiLCJ0aWQiOiJiM2NmZDNhNS03MzFiLTQ4ZTctYWE4NS05YTBlMDU4NzA0NTMiLCJ1bmlxdWVfbmFtZSI6IjdmNzZlMjZiLTQ1YTAtNDc2My1iMzZjLTdkNzRlZmNmZDYxNkBFYXRvbklvVEFkb3B0ZXJBREIyQy5vbm1pY3Jvc29mdC5jb20iLCJ1cG4iOiI3Zjc2ZTI2Yi00NWEwLTQ3NjMtYjM2Yy03ZDc0ZWZjZmQ2MTZARWF0b25Jb1RBZG9wdGVyQURCMkMub25taWNyb3NvZnQuY29tIiwidXRpIjoiMGw1M2k0OS1sa2lxMzBGYmQ4VENBUSIsInZlciI6IjEuMCJ9.R40cMfqQh6pHUmx7OLVdb-sLLL-_RocJYzZ8_9rItQNTufegoemWUa3Cx0Ovy6m8KvbxhkgWY1EshGByFMxI9HnNU8Lywq4jE_0nMq5UGL5RwxFrGLIlHa2qk-mALm_48qQb7Dg7BJ69oYKUlX0TPKQN7qxXceVB1NCKafuFGBD3l4ogIs-Lbyo_qe0wwHZ3HCXGpn0ZQh-6rb4en7y1HCtH_J5t2WyTzvGGXXuVCDoBbiGdZk-tnDDbvmrvhkpTvjSsuRsRIaq83VBtk7YC7dPRy5Otn95xunKgWzZWQuj8FinB5rHGQ6IV9j_jpI0VhC521SdcW2gt2hR1HptKsg";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("Bearer",tk.Token);

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