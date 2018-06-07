using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule
    /// Use the AWS::IoT::TopicRule resource to declare an AWS IoT rule.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html
    /// </summary>
    public class TopicRuleResource : ResourceBase
    {
        public class TopicRuleProperties
        {
            /// <summary>
            /// RuleName
            /// The name (the physical ID) of the AWS IoT rule.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html#cfn-iot-topicrule-rulename
            /// </summary>
			public Union<string, IntrinsicFunction> RuleName { get; set; }

            /// <summary>
            /// TopicRulePayload
            /// The actions associated with the AWS IoT rule.
            /// Required: Yes
            /// Type: TopicRulePayload object
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html#cfn-iot-topicrule-topicrulepayload
            /// </summary>
			public Union<TopicRulePayload, IntrinsicFunction> TopicRulePayload { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::TopicRule";
        
        public TopicRuleProperties Properties { get; } = new TopicRuleProperties();
    }

	public static class TopicRuleAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
