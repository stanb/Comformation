using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.DeliveryChannel
{
    /// <summary>
    /// AWS::Config::DeliveryChannel
    /// The AWS::Config::DeliveryChannel resource describes where AWS Config sends notifications and updated
    /// configuration states for AWS resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html
    /// </summary>
    public class DeliveryChannelResource : ResourceBase
    {
        public class DeliveryChannelProperties
        {
            /// <summary>
            /// ConfigSnapshotDeliveryProperties
            /// Provides options for how AWS Config delivers configuration snapshots to the S3 bucket in your
            /// delivery channel.
            /// Required: No
            /// Type: AWS Config DeliveryChannel ConfigSnapshotDeliveryProperties
            /// Update requires: No interruption
            /// </summary>
			public Union<ConfigSnapshotDeliveryProperties, IntrinsicFunction> ConfigSnapshotDeliveryProperties { get; set; }

            /// <summary>
            /// Name
            /// A name for the delivery channel. If you don't specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the delivery channel name. For more information, see Name Type.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported. To change the name, you must run two separate updates.
            /// In the first update, delete this resource, and then recreate it with a new name in the second
            /// update.
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// S3BucketName
            /// The name of an S3 bucket where you want to store configuration history for the delivery channel.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> S3BucketName { get; set; }

            /// <summary>
            /// S3KeyPrefix
            /// A key prefix (folder) for the specified S3 bucket.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

            /// <summary>
            /// SnsTopicARN
            /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (Amazon SNS) topic that AWS
            /// Config delivers notifications to.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnsTopicARN { get; set; }

        }
    
        public string Type { get; } = "AWS::Config::DeliveryChannel";
        
        public DeliveryChannelProperties Properties { get; } = new DeliveryChannelProperties();
    }
}
