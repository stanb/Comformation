using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.AccessPoint
{
    /// <summary>
    /// AWS::EFS::AccessPoint AccessPointTag
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-accesspointtag.html
    /// </summary>
    public class AccessPointTag
    {

        /// <summary>
        /// Key
        /// The tag key (String). The key can&#39;t start with aws:.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^(?![aA]{1}[wW]{1}[sS]{1}:)([\p{L}\p{Z}\p{N}_. :/=+\-@]+)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value of the tag key.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: ^([\p{L}\p{Z}\p{N}_. :/=+\-@]*)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
