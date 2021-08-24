using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL BlockAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-blockaction.html
    /// </summary>
    public class BlockAction
    {

        /// <summary>
        /// CustomResponse
        /// Defines a custom response for the web request.
        /// For information about customizing web requests and responses, see Customizing web requests and
        /// responses in AWS WAF in the AWS WAF Developer Guide.
        /// Required: No
        /// Type: CustomResponse
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomResponse")]
        public CustomResponse CustomResponse { get; set; }

    }
}
