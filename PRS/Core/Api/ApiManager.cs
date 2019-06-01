using System;
using System.Net;
using System.Text;
using Royale2Sharp.Core.Settings;

namespace Royale2Sharp.Core.Api
{
    internal class ApiManager
    {
        internal ApiManager()
        {
            var web = new HttpListener();

            web.Prefixes.Add("http://localhost:8080/");

            Console.WriteLine("WebApi started!");

            web.Start();

            Console.WriteLine(web.GetContext());

            var context = web.GetContext();

            var response = context.Response;

            var responseString = $"<html><body>Connected users : {Constants.ServerConfig.ConnectedUsers}</body></html>";

            var buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;

            var output = response.OutputStream;

            output.Write(buffer, 0, buffer.Length);

            Console.WriteLine(output);

            output.Close();

            web.Stop();
        }
    }
}