using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Topic
{
    /// <summary>
    /// AWS::SNS::Topic
    /// The AWS::SNS::Topic type creates an Amazon Simple Notification Service (Amazon SNS) topic.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html
    /// </summary>
    public class TopicResource : ResourceBase
    {
        public class TopicProperties
        {
            /// <summary>
            /// DisplayName
            /// A developer-defined string that can be used to identify this SNS topic.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// KmsMasterKeyId
            /// An AWS KMS key identifier. This can be a key ID, key ARN, or key alias.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsMasterKeyId { get; set; }

            /// <summary>
            /// Subscription
            /// The SNS subscriptions (endpoints) for this topic.
            /// Required: No
            /// Type: List of SNS Subscriptions
            /// Update requires: No interruption
            /// </summary>
			public List<Subscription> Subscription { get; set; }

            /// <summary>
            /// TopicName
            /// A name for the topic. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the topic name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TopicName { get; set; }

        }

        public string Type { get; } = "AWS::SNS::Topic";

        public TopicProperties Properties { get; } = new TopicProperties();

    }

	public static class TopicAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TopicName = new ResourceAttribute<Union<string, IntrinsicFunction>>("TopicName");
	}
}
