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

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the topic rule.
            /// Note For URI Request parameters use format: . . . key1=value1&amp;amp;key2=value2. . . For the CLI
            /// command-line parameter use format: --tags &quot;key1=value1&amp;amp;key2=value2. . . &quot; For the cli-input-json
            /// file use format: &quot;tags&quot;: &quot;key1=value1&amp;amp;key2=value2. . . &quot;
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::TopicRule";

        public TopicRuleProperties Properties { get; } = new TopicRuleProperties();

    }

    public static class TopicRuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
