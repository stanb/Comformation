using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SNS.Topic
{
    /// <summary>
    /// AWS::SNS::Topic
    /// The AWS::SNS::Topic resource creates a topic to which notifications can be published.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html
    /// </summary>
    public class TopicResource : ResourceBase
    {
        public class TopicProperties
        {
            /// <summary>
            /// DisplayName
            /// The display name to use for an Amazon SNS topic with SMS subscriptions.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// KmsMasterKeyId
            /// The ID of an AWS-managed customer master key (CMK) for Amazon SNS or a custom CMK. For more
            /// information, see Key Terms. For more examples, see KeyId in the AWS Key Management Service API
            /// Reference.
            /// This property applies only to server-side-encryption.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> KmsMasterKeyId { get; set; }

            /// <summary>
            /// Subscription
            /// The SNS subscriptions (endpoints) for this topic.
            /// Required: No
            /// Type: List of Subscription
            /// Update requires: No interruption
            /// </summary>
			public List<Subscription> Subscription { get; set; }

            /// <summary>
            /// TopicName
            /// The name of the topic you want to create. Topic names must include only uppercase and lowercase
            /// ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for
            /// the topic name. For more information, see Name Type.
            /// Important If you specify a name, you can&#39;t perform updates that require replacement of this
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
