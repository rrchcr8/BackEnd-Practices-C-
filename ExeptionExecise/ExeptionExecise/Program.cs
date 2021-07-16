using System;
using System.Data.SqlClient;
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
            //webfilter
            when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {

            }
            catch (Exception)
            {

            }
            finally {
                webClient.Dispose();
            }
        }

        public static void DoBilling(int clientID) { 
        
        Client client   = _client

        }

        public class ClientBillingException : Exception { 
        
        }

        //HIdden Exeption
        public static DateTime? GetDate(SqlDataReader reader, string columnname) {

            DateTime? dateTime = null;
            try
            {
            }
            catch
            {
            }
        }

        



    
    }
}
