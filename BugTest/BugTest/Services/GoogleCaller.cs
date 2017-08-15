using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTest.Contract;

namespace BugTest.Services
{
    public class GoogleCaller : IGoogleCall
    {
        public async Task<string> CallGoogle()
        {
            //var client = new HttpClient();
            //var response = await client.GetAsync("http://www.google.com");

            //string content = "";
            //if (response.IsSuccessStatusCode)
            //{
            //    content = await response.Content.ReadAsStringAsync();
            //}


            //var resolt = content;
            //return resolt;
            return "blah blah";
        }
    }
}
