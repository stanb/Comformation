using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Comformation
{
    public class Template
    {
        private static readonly JsonSerializer Serializer;
        static Template()
        {
            Serializer = new JsonSerializer();
            Serializer.Converters.Add(new RawJsonConverter());
            Serializer.NullValueHandling = NullValueHandling.Ignore;
        }
        
        [JsonProperty("AWSTemplateFormatVersion")]
        public string Version { get; } = "2010-09-09";

        [MaxLength(1024)]
        public string Description { get; set; }
        
        public Metadata Metadata { get; set; }
        
        public Parameters Parameters { get; set; }

        public Mappings Mappings { get; set; }

        public Conditions Conditions { get; set; }

        public JToken Transform { get; set; }
        
        public Resources Resources { get; set; }
        
        public Outputs Outputs { get; set; }

        public JToken ToJson()
        {
            return JToken.FromObject(this, Serializer);
        }

        public override string ToString()
        {
            return ToJson().ToString();
        }
    }
}
