using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Subscription
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html
    /// </summary>
    public class SubscriptionResource : ResourceBase
    {
        public class SubscriptionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-endpoint
            /// </summary>
			public Union<string, IntrinsicFunction> Endpoint { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-protocol
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#topicarn
            /// </summary>
			public Union<string, IntrinsicFunction> TopicArn { get; set; }

        }
    
        public string Type { get; } = "AWS::SNS::Subscription";
        
        public SubscriptionProperties Properties { get; } = new SubscriptionProperties();
    }
}
