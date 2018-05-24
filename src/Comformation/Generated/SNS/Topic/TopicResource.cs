using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Topic
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html
    /// </summary>
    public class TopicResource : ResourceBase
    {
        public class TopicProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html#cfn-sns-topic-displayname
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html#cfn-sns-topic-subscription
            /// </summary>
			public Union<List<Subscription>, IntrinsicFunction> Subscription { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html#cfn-sns-topic-topicname
            /// </summary>
			public Union<string, IntrinsicFunction> TopicName { get; set; }

        }
    
        public string Type { get; } = "AWS::SNS::Topic";
        
        public TopicProperties Properties { get; } = new TopicProperties();
    }

	public static class TopicAttributes
	{
        public static readonly ResourceAttribute<string> TopicName = new ResourceAttribute<string>("TopicName");
	}
}
