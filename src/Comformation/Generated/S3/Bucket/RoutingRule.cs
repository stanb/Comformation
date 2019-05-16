using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket RoutingRule
    /// Specifies the redirect behavior and when a redirect is applied.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html
    /// </summary>
    public class RoutingRule
    {

        /// <summary>
        /// RedirectRule
        /// Container for redirect information. You can redirect requests to another host, to another page, or
        /// with another protocol. In the event of an error, you can specify a different error code to return.
        /// Required: Yes
        /// Type: RedirectRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedirectRule")]
        public RedirectRule RedirectRule { get; set; }

        /// <summary>
        /// RoutingRuleCondition
        /// A container for describing a condition that must be met for the specified redirect to apply. For
        /// example, 1. If request is for pages in the /docs folder, redirect to the /documents folder. 2. If
        /// request results in HTTP error 4xx, redirect request to another host where you might process the
        /// error.
        /// Required: No
        /// Type: RoutingRuleCondition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoutingRuleCondition")]
        public RoutingRuleCondition RoutingRuleCondition { get; set; }

    }
}
