using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL AllowAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-allowaction.html
    /// </summary>
    public class AllowAction
    {

        /// <summary>
        /// CustomRequestHandling
        /// Defines custom handling for the web request.
        /// For information about customizing web requests and responses, see Customizing web requests and
        /// responses in AWS WAF in the AWS WAF Developer Guide.
        /// Required: No
        /// Type: CustomRequestHandling
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomRequestHandling")]
        public CustomRequestHandling CustomRequestHandling { get; set; }

    }
}
