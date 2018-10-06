using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.TopicPolicy
{
    /// <summary>
    /// AWS::SNS::TopicPolicy
    /// The AWS::SNS::TopicPolicy resource associates Amazon SNS topics with a policy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-policy.html
    /// </summary>
    public class TopicPolicyResource : ResourceBase
    {
        public class TopicPolicyProperties
        {
            /// <summary>
            /// PolicyDocument
            /// A policy document that contains permissions to add to the specified SNS topics.
            /// Required: Yes
            /// JSON or YAML
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// Topics
            /// The Amazon Resource Names (ARN) of the topics to which you want to add the policy. You can use the
            /// Ref function to specify an AWS::SNS::Topic resource.
            /// Required: Yes
            /// Type: A list of Amazon SNS topics ARNs
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Topics { get; set; }

        }
    
        public string Type { get; } = "AWS::SNS::TopicPolicy";
        
        public TopicPolicyProperties Properties { get; } = new TopicPolicyProperties();

    }
}
