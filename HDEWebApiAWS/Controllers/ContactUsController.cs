
using System;
using System.Text;
using HDEWebApiAWS.DB;
using System.Net.Http;
using System.Data.SqlClient;
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
            string connectionString = DBHelper.GetRDSConnectionString();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "Insert into contact_us(contact_us_id, contact_us_name, contact_us_email, contact_us_message) " +
                        "values('" + System.Guid.NewGuid() + "','" + name + "','" + email + "','" + message + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message.ToString());
                throw;
            }

            // your code here
            return new JsonResult(true);
        }
        
    }
}
