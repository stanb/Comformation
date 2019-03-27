using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket RoutingRules
    /// The RoutingRules property is an embedded property of the WebsiteConfiguration property. This property
    /// describes the redirect behavior and when a redirect is applied.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html
    /// </summary>
    public class RoutingRule
    {

        /// <summary>
        /// RedirectRule
        /// Redirect requests to another host, to another page, or with another protocol.
        /// Required: Yes
        /// Type: RedirectRule
        /// </summary>
        [JsonProperty("RedirectRule")]
        public RedirectRule RedirectRule { get; set; }

        /// <summary>
        /// RoutingRuleCondition
        /// Rules that define when a redirect is applied.
        /// Required: No
        /// Type: RoutingRuleCondition
        /// </summary>
        [JsonProperty("RoutingRuleCondition")]
        public RoutingRuleCondition RoutingRuleCondition { get; set; }

    }
}
