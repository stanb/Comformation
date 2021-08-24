using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL CustomRequestHandling
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-customrequesthandling.html
    /// </summary>
    public class CustomRequestHandling
    {

        /// <summary>
        /// InsertHeaders
        /// The HTTP headers to insert into the request. Duplicate header names are not allowed.
        /// For information about the limits on count and size for custom request and response settings, see AWS
        /// WAF quotas in the AWS WAF Developer Guide.
        /// Required: Yes
        /// Type: List of CustomHTTPHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InsertHeaders")]
        public List<CustomHTTPHeader> InsertHeaders { get; set; }

    }
}
