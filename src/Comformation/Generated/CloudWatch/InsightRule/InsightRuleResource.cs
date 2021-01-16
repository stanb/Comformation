using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.InsightRule
{
    /// <summary>
    /// AWS::CloudWatch::InsightRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-insightrule.html
    /// </summary>
    public class InsightRuleResource : ResourceBase
    {
        public class InsightRuleProperties
        {
            /// <summary>
            /// RuleState
            /// The current state of the rule. Valid values are ENABLED and DISABLED.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleState { get; set; }

            /// <summary>
            /// RuleBody
            /// The definition of the rule, as a JSON object. For details about the syntax, see Contributor Insights
            /// Rule Syntax in the Amazon CloudWatch User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleBody { get; set; }

            /// <summary>
            /// RuleName
            /// The name of the rule.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RuleName { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs to associate with the Contributor Insights rule. You can associate as many
            /// as 50 tags with a rule.
            /// Tags can help you organize and categorize your resources. For more information, see Tagging Your
            /// Amazon CloudWatch Resources.
            /// To be able to associate tags with a rule, you must have the cloudwatch:TagResource permission in
            /// addition to the cloudwatch:PutInsightRule permission.
            /// Required: No
            /// Type: Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CloudWatch::InsightRule";

        public InsightRuleProperties Properties { get; } = new InsightRuleProperties();

    }

    public static class InsightRuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RuleName = new ResourceAttribute<Union<string, IntrinsicFunction>>("RuleName");
    }
}
