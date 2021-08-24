using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.LoggingConfiguration
{
    /// <summary>
    /// AWS::WAFv2::LoggingConfiguration FieldToMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-loggingconfiguration-fieldtomatch.html
    /// </summary>
    public class FieldToMatch
    {

        /// <summary>
        /// JsonBody
        /// Redact the JSON body from the logs.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonBody")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> JsonBody { get; set; }

        /// <summary>
        /// Method
        /// Redact the method from the logs.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Method")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Method { get; set; }

        /// <summary>
        /// QueryString
        /// Redact the query string from the logs.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryString")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> QueryString { get; set; }

        /// <summary>
        /// SingleHeader
        /// Redact the header from the logs.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SingleHeader")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SingleHeader { get; set; }

        /// <summary>
        /// UriPath
        /// Redact the URI path from the logs.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UriPath")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> UriPath { get; set; }

    }
}
