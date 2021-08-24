using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL LabelMatchStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-labelmatchstatement.html
    /// </summary>
    public class LabelMatchStatement
    {

        /// <summary>
        /// Scope
        /// Specify whether you want to match using the label name or just the namespace.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scope")]
        public Union<string, IntrinsicFunction> Scope { get; set; }

        /// <summary>
        /// Key
        /// The string to match against. The setting you provide for this depends on the match statement&#39;s Scope
        /// setting:
        /// If the Scope indicates LABEL, then this specification must include the name and can include any
        /// number of preceding namespace specifications and prefix up to providing the fully qualified label
        /// name. If the Scope indicates NAMESPACE, then this specification can include any number of contiguous
        /// namespace strings, and can include the entire label namespace prefix from the rule group or web ACL
        /// where the label originates.
        /// Labels are case sensitive and components of a label must be separated by colon, for example
        /// NS1:NS2:name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
