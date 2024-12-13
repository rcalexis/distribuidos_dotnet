using Distribuidos.Api.Models;  
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;  

namespace Distribuidos.Api.Services
{
    public class PipedreamService : IPipedreamService
    {
        public async Task<bool> SendWelcome(WelcomeModel body)
        {
            string url = "https://eo1s74n4jewu36w.m.pipedream.net";
            var cliente = new HttpClient();
            var byeData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new 
            { 
                user_name = body.UserName,  
                email = body.Email
            }));

            using (var content = new ByteArrayContent(byeData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");  
                var response = await cliente.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
    }
}


// using Distribuidos.Api.Services;
// using Systems.Text;


// namespace Distribuidos.Api.Services
// {
//     public class PipedreamService : IPipedreamService
//     {
//         public async Task<bool> SendWelcome(WelcomeModel body)
//         {
//             string url = "https://eo1s74n4jewu36w.m.pipedream.net";
//             var cliente = new HttpClient();
//             var byeData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { user_name = body.user_name, email = body.Email }));

//             using (var content = new ByteArrayContent(byeData))
//             {
//                 content.Headers.ContentType = new MediaTypeHeaderValue("aplication/json");
//                 var response = await cliente.PostAsync(url, content);

//                 if (response.IsSuccessStatusCode)
//                 {
//                     return true
//                 }
//                 return false
//             }
//         }
//     }
// }