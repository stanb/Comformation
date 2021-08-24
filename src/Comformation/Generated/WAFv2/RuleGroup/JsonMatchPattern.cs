using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup JsonMatchPattern
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-jsonmatchpattern.html
    /// </summary>
    public class JsonMatchPattern
    {

        /// <summary>
        /// All
        /// Match all of the elements. See also MatchScope in JsonBody.
        /// You must specify either this setting or the IncludedPaths setting, but not both.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("All")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> All { get; set; }

        /// <summary>
        /// IncludedPaths
        /// Match only the specified include paths. See also MatchScope in JsonBody.
        /// Provide the include paths using JSON Pointer syntax. For example, &quot;IncludedPaths&quot;: [&quot;/dogs/0/name&quot;,
        /// &quot;/dogs/1/name&quot;]. For information about this syntax, see the Internet Engineering Task Force (IETF)
        /// documentation JavaScript Object Notation (JSON) Pointer.
        /// You must specify either this setting or the All setting, but not both.
        /// Note Don&#39;t use this option to include all paths. Instead, use the All setting.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludedPaths")]
        public List<Union<string, IntrinsicFunction>> IncludedPaths { get; set; }

    }
}
