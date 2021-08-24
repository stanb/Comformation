using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL CustomResponseBody
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customresponsebody.html
    /// </summary>
    public class CustomResponseBody
    {

        /// <summary>
        /// ContentType
        /// The type of content in the payload that you are defining in the Content string.
        /// Required: Yes
        /// Type: String
        /// Allowed values: APPLICATION_JSON | TEXT_HTML | TEXT_PLAIN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentType")]
        public Union<string, IntrinsicFunction> ContentType { get; set; }

        /// <summary>
        /// Content
        /// The payload of the custom response.
        /// You can use JSON escape strings in JSON content. To do this, you must specify JSON content in the
        /// ContentType setting.
        /// For information about the limits on count and size for custom request and response settings, see AWS
        /// WAF quotas in the AWS WAF Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 10240
        /// Pattern: [\s\S]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Content")]
        public Union<string, IntrinsicFunction> Content { get; set; }

    }
}
