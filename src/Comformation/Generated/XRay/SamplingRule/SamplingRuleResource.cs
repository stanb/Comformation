using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.XRay.SamplingRule
{
    /// <summary>
    /// AWS::XRay::SamplingRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-samplingrule.html
    /// </summary>
    public class SamplingRuleResource : ResourceBase
    {
        public class SamplingRuleProperties
        {
            /// <summary>
            /// SamplingRule
            /// The sampling rule to be created.
            /// Must be provided if creating a new sampling rule. Not valid when updating an existing sampling rule.
            /// Required: Conditional
            /// Type: SamplingRule
            /// Update requires: No interruption
            /// </summary>
            public SamplingRule SamplingRule { get; set; }

            /// <summary>
            /// SamplingRuleRecord
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: SamplingRuleRecord
            /// Update requires: No interruption
            /// </summary>
            public SamplingRuleRecord SamplingRuleRecord { get; set; }

            /// <summary>
            /// SamplingRuleUpdate
            /// A document specifying changes to a sampling rule&#39;s configuration.
            /// Must be provided if updating an existing sampling rule. Not valid when creating a new sampling rule.
            /// Note The Version of a sampling rule cannot be updated, and is not part of SamplingRuleUpdate.
            /// Required: Conditional
            /// Type: SamplingRuleUpdate
            /// Update requires: No interruption
            /// </summary>
            public SamplingRuleUpdate SamplingRuleUpdate { get; set; }

            /// <summary>
            /// RuleName
            /// The name of the sampling rule. Specify a rule by either name or ARN, but not both. Used only when
            /// deleting a sampling rule. When creating or updating a sampling rule, use the RuleName or RuleARN
            /// properties within SamplingRule or SamplingRuleUpdate.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleName { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Json
            /// Update requires: No interruption
            /// </summary>
            public List<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::XRay::SamplingRule";

        public SamplingRuleProperties Properties { get; } = new SamplingRuleProperties();

    }

    public static class SamplingRuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RuleARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("RuleARN");
    }
}
