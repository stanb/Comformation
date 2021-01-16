using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBProxy
{
    /// <summary>
    /// AWS::RDS::DBProxy TagFormat
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-tagformat.html
    /// </summary>
    public class TagFormat
    {

        /// <summary>
        /// Key
        /// A key is the required name of the tag. The string value can be 1-128 Unicode characters in length
        /// and can&#39;t be prefixed with &quot;aws:&quot;. The string can contain only the set of Unicode letters, digits,
        /// white-space, &#39;_&#39;, &#39;. &#39;, &#39;/&#39;, &#39;=&#39;, &#39;+&#39;, &#39;-&#39; (Java regex: &quot;^([\\p{L}\\p{Z}\\p{N}_. :/=+\\-]*)$&quot;).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// A value is the optional value of the tag. The string value can be 1-256 Unicode characters in length
        /// and can&#39;t be prefixed with &quot;aws:&quot;. The string can contain only the set of Unicode letters, digits,
        /// white-space, &#39;_&#39;, &#39;. &#39;, &#39;/&#39;, &#39;=&#39;, &#39;+&#39;, &#39;-&#39; (Java regex: &quot;^([\\p{L}\\p{Z}\\p{N}_. :/=+\\-]*)$&quot;).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
