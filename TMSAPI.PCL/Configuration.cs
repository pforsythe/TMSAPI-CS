using System.Collections.Generic;
using System.Text;
using TMSAPI.PCL.Models;
using TMSAPI.PCL.Utilities;

namespace TMSAPI.PCL
{
    public partial class Configuration
    {
        public enum Environments
        {
            PRODUCTION,
            //Testing Environment
            QA,
            //Development Environment
            DEV,
        }
        public enum Servers
        {
            DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //The username to use with basic authentication
        //TODO: Replace the BasicAuthUserName with an appropriate value
        public static string BasicAuthUserName = "TODO: Replace";

        //The password to use with basic authentication
        //TODO: Replace the BasicAuthPassword with an appropriate value
        public static string BasicAuthPassword = "TODO: Replace";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"http://tms.afspulse.net/api" },
                    }
                },
                { 
                    Environments.QA,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"http://tmsqa.afspulse.net/api" },
                    }
                },
                { 
                    Environments.DEV,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"http://tmsdev.afspulse.net/api" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}