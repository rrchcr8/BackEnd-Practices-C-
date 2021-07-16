using System;
using System.Net;

namespace ExeptionExecise
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = null;

            try
            {
                webClient = new WebClient();
                var result = webClient.DownloadString("https://www.google.com");
            }
            catch (ArgumentNullException ex)
            {

            }
            catch (WebException ex)
            w//hen ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {

            }
            catch (Exception)
            {

            }
            finally {
                webClient.Dispose();
            }
        }
    }
}
