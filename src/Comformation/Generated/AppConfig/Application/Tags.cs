using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.Application
{
    /// <summary>
    /// AWS::AppConfig::Application Tags
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-application-tags.html
    /// </summary>
    public class Tags
    {

        /// <summary>
        /// Value
        /// The tag value can be up to 256 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The key-value string map. The valid character set is [a-zA-Z+-=. _:/]. The tag key can be up to 128
        /// characters and must not start with aws:.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
