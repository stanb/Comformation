using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL Label
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-label.html
    /// </summary>
    public class Label
    {

        /// <summary>
        /// Name
        /// The label string.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^[0-9A-Za-z_\-:]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
