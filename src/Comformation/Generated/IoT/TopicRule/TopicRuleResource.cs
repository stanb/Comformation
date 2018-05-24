using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html
    /// </summary>
    public class TopicRuleResource : ResourceBase
    {
        public class TopicRuleProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html#cfn-iot-topicrule-rulename
            /// </summary>
			public Union<string, IntrinsicFunction> RuleName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html#cfn-iot-topicrule-topicrulepayload
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
