using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.DeliveryChannel
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html
    /// </summary>
    public class DeliveryChannelResource : ResourceBase
    {
        public class DeliveryChannelProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-configsnapshotdeliveryproperties
            /// </summary>
			public Union<ConfigSnapshotDeliveryProperties, IntrinsicFunction> ConfigSnapshotDeliveryProperties { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3bucketname
            /// </summary>
			public Union<string, IntrinsicFunction> S3BucketName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-s3keyprefix
            /// </summary>
			public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-deliverychannel.html#cfn-config-deliverychannel-snstopicarn
            /// </summary>
			public Union<string, IntrinsicFunction> SnsTopicARN { get; set; }

        }
    
        public string Type { get; } = "AWS::Config::DeliveryChannel";
        
        public DeliveryChannelProperties Properties { get; } = new DeliveryChannelProperties();
    }
}
