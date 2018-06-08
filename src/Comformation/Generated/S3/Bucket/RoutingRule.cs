using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Website Configuration Routing Rules Property
    /// The RoutingRules property is an embedded property of the Amazon S3 Website Configuration Property property.
    /// This property describes the redirect behavior and when a redirect is applied.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html
    /// </summary>
    public class RoutingRule
    {

        /// <summary>
        /// RedirectRule
        /// Redirect requests to another host, to another page, or with another protocol.
        /// Required: Yes
        /// Type: Amazon S3 Website Configuration Routing Rules Redirect Rule Property
        /// </summary>
        [JsonProperty("RedirectRule")]
        public Union<RedirectRule, IntrinsicFunction> RedirectRule { get; set; }

        /// <summary>
        /// RoutingRuleCondition
        /// Rules that define when a redirect is applied.
        /// Required: No
        /// Type: Amazon S3 Website Configuration Routing Rules Routing Rule Condition Property
        /// </summary>
        [JsonProperty("RoutingRuleCondition")]
        public Union<RoutingRuleCondition, IntrinsicFunction> RoutingRuleCondition { get; set; }

    }
}
