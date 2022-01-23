using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Chrypto.Entities.Common
{
    public static class Parameters
    {
        public static readonly string API_KEY = ConfigurationManager.AppSettings["API_KEY"].ToString();

        public static readonly string BASE_URL = ConfigurationManager.AppSettings["BASE_URL"].ToString();
        public static readonly string LIMIT = ConfigurationManager.AppSettings["LIMIT"].ToString();
    }
}
