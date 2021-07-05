using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace YaloTest.Base
{
    public class JsonReaderHelper
    {
        public static T DataFileReader<T>(string pathFile)
        {
            var jsonOutput = File.ReadAllText(pathFile);
            var jsonData = JsonConvert.DeserializeObject<T>(jsonOutput);

            return jsonData;
        }

    }
}
