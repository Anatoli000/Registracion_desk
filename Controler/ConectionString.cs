using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Касса_БЕЛ_ЖД.Controller
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Касса_БЕЛ_ЖД.Properties.Settings.Касса_ЖД_вокзалаConnectionString"].ConnectionString;
            }
        }
    }
}
