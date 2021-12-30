using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MapAssist.Settings
{
    class ItemClass
    {
        public static JObject _itemClass;
        public static void Load()
        {
            var _path = AppDomain.CurrentDomain.BaseDirectory;
            var jstxt = System.IO.File.ReadAllText(_path + "\\Item_class.json");
            var js = (JObject)JsonConvert.DeserializeObject(jstxt);
            _itemClass = js;
        }

    }
}
