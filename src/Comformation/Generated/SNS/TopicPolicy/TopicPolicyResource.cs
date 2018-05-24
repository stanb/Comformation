using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.TopicPolicy
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-policy.html
    /// </summary>
    public class TopicPolicyResource : ResourceBase
    {
        public class TopicPolicyProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-policy.html#cfn-sns-topicpolicy-policydocument
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-policy.html#cfn-sns-topicpolicy-topics
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Topics { get; set; }

        }
    
        public string Type { get; } = "AWS::SNS::TopicPolicy";
        
        public TopicPolicyProperties Properties { get; } = new TopicPolicyProperties();
    }
}
