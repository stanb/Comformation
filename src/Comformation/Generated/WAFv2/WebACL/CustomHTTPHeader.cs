using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL CustomHTTPHeader
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customhttpheader.html
    /// </summary>
    public class CustomHTTPHeader
    {

        /// <summary>
        /// Name
        /// The name of the custom header.
        /// For custom request header insertion, when AWS WAF inserts the header into the request, it prefixes
        /// this name x-amzn-waf-, to avoid confusion with the headers that are already in the request. For
        /// example, for the header name sample, AWS WAF inserts the header x-amzn-waf-sample.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[a-zA-Z0-9. _$-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value of the custom header.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
