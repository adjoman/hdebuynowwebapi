
using System;
using System.Text;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HDEWebApiAWS.Controllers
{
    [Route("[controller]")]
    public class ContactUsController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            List<string> timeZones = new List<string>();

            timeZones.Add("1");
            timeZones.Add("2");
            timeZones.Add("3");
            timeZones.Add("4");
            timeZones.Add("5");
            
            return Ok(timeZones);
        }

        [HttpGet("ReadMyData/{param1}")]
        public HttpResponseMessage ReadMyData(string param1)
        {
            // your code here
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        [HttpGet("ContactMessage/{name}/{email}/{message}")]
        public JsonResult ContactMessage(string name, string email, string message)
        {
            // your code here
            return new JsonResult(true);
        }
        
    }
}
