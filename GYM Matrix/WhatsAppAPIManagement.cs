using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.Windows.Forms;

namespace GYM_Matrix
{
    class WhatsAppAPIManagement
    {
        public static void Fee_Reminder()
        {
            var client = new RestClient("https://graph.facebook.com/v16.0/");

            var request = new RestRequest("102127016182484/messages", Method.POST);

            request.AddHeader("Authorization", "Bearer EAAT9qZACSzlkBAH10UEhtyuQHgSgimuyKjaUGrDc43BmIqS2Pg7cy8aDtNI428Ll3IWkdJz3Mmte6VRzsS1wLLqDV044PlNmN3gDZCd7AsxAzzE2f4vKy3LM3YJWqj716vIL1ZAG5PsXgDK5ZBqKlmhNlfIZAlKH9MQCxSwLMBm4YPvMHIS8AGoI6lRSjx4X82KUmab9YlQZDZD");
            request.AddHeader("Content-Type", "application/json");

            var payload = new
            {
                messaging_product = "whatsapp",
                to = "923331245518",
                type = "template",
                template = new
                {
                    name = "hello_world",
                    language = new
                    {
                        code = "en_US"
                    }
                }
            };

            request.AddJsonBody(payload);

            var response = client.Execute(request);

            MessageBox.Show(response.StatusCode.ToString());
           


        }
    }
}
