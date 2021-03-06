using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html
    /// </summary>
    public class TopicRuleResource : ResourceBase
    {
        public class TopicRuleProperties
        {
            /// <summary>
            /// RuleName
            /// The name of the rule.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RuleName { get; set; }

            /// <summary>
            /// TopicRulePayload
            /// The rule payload.
            /// Required: Yes
            /// Type: TopicRulePayload
            /// Update requires: No interruption
            /// </summary>
            public TopicRulePayload TopicRulePayload { get; set; }

        }

        public string Type { get; } = "AWS::IoT::TopicRule";

        public TopicRuleProperties Properties { get; } = new TopicRuleProperties();

    }

    public static class TopicRuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
