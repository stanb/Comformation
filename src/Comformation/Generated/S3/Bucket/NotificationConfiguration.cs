using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html#cfn-s3-bucket-notificationconfig-lambdaconfig
        /// </summary>
        [JsonProperty("LambdaConfigurations")]
        public Union<List<LambdaConfiguration>, IntrinsicFunction> LambdaConfigurations { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html#cfn-s3-bucket-notificationconfig-queueconfig
        /// </summary>
        [JsonProperty("QueueConfigurations")]
        public Union<List<QueueConfiguration>, IntrinsicFunction> QueueConfigurations { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html#cfn-s3-bucket-notificationconfig-topicconfig
        /// </summary>
        [JsonProperty("TopicConfigurations")]
        public Union<List<TopicConfiguration>, IntrinsicFunction> TopicConfigurations { get; set; }

    }
}
