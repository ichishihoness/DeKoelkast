using DeKoelkast.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeKoelkast.Api;

namespace DeKoelkast.Api
{
    public class ApiQuestion
    {
        public async static Task<Question> GetTruth()
        {
            Question result = new Question();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(Constants.API_URL_TRUTH);
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<Question>(json) as Question;
            }
            return result;
        }
    }
}