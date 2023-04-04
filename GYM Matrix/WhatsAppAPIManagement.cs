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

            request.AddHeader("Authorization", "Bearer EAAT9qZACSzlkBAOon6fu1aa6ptDcMCpQHZBATPQE4y2NSvHDORMfvNEk4DpMB6oH89Bl4XVsIpjNODGZCsH6mPGvUHHIbl9FDT0EQbfRB7MveHAy6JfGGaPi2Gw22IgBvCmaGzOZCH6AHZAsZAS8PftnYZBdpsDZBH8wezZBeEF6dUdvw85PMV6n8ZAoCST5SMa5xVouaqSqeOJwZDZD");
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

            MessageBox.Show(response.ErrorMessage);
           


        }
    }
}
