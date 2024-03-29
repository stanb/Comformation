using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.DeliveryChannel
{
    /// <summary>
    /// AWS::Config::DeliveryChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html
    /// </summary>
    public class DeliveryChannelResource : ResourceBase
    {
        public class DeliveryChannelProperties
        {
            /// <summary>
            /// ConfigSnapshotDeliveryProperties
            /// 		
            /// The options for how often AWS Config delivers configuration 			snapshots to the Amazon S3 bucket.
            /// 	
            /// Required: No
            /// Type: ConfigSnapshotDeliveryProperties
            /// Update requires: No interruption
            /// </summary>
            public ConfigSnapshotDeliveryProperties ConfigSnapshotDeliveryProperties { get; set; }

            /// <summary>
            /// Name
            /// A name for the delivery channel. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the delivery channel name. For more information, see Name Type.
            /// Updates are not supported. To change the name, you must run two separate updates. In the first
            /// update, delete this resource, and then recreate it with a new name in the second update.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// S3BucketName
            /// 		
            /// The name of the Amazon S3 bucket to which AWS Config delivers 			configuration snapshots and
            /// configuration history files.
            /// 		
            /// If you specify a bucket that belongs to another AWS account, 			that bucket must have policies that
            /// grant access permissions to AWS Config. For more information, see Permissions for the Amazon S3
            /// Bucket in the AWS Config 			Developer Guide.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3BucketName { get; set; }

            /// <summary>
            /// S3KeyPrefix
            /// 		
            /// The prefix for the specified Amazon S3 bucket.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

            /// <summary>
            /// S3KmsKeyArn
            /// 		
            /// The Amazon Resource Name (ARN) of the AWS Key Management Service (KMS) customer managed key (CMK)
            /// used to encrypt objects delivered by AWS Config. 			Must belong to the same Region as the
            /// destination S3 bucket.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> S3KmsKeyArn { get; set; }

            /// <summary>
            /// SnsTopicARN
            /// 		
            /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which 			AWS Config sends notifications
            /// about configuration 			changes.
            /// 		
            /// If you choose a topic from another account, the topic must have 			policies that grant access
            /// permissions to AWS Config. For more 			information, see Permissions for the Amazon SNS Topic in the
            /// AWS Config 			Developer Guide.
            /// 	
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
