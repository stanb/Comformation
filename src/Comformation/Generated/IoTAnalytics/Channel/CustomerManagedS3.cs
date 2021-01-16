using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Channel
{
    /// <summary>
    /// AWS::IoTAnalytics::Channel CustomerManagedS3
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-customermanageds3.html
    /// </summary>
    public class CustomerManagedS3
    {

        /// <summary>
        /// Bucket
        /// The name of the Amazon S3 bucket in which channel data is stored.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role which grants AWS IoT Analytics permission to interact with your Amazon S3
        /// resources.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// KeyPrefix
        /// [Optional] The prefix used to create the keys of the channel data objects. Each object in an Amazon
        /// S3 bucket has a key that is its unique identifier within the bucket (each object in a bucket has
        /// exactly one key). The prefix must end with a &#39;/&#39;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyPrefix")]
        public Union<string, IntrinsicFunction> KeyPrefix { get; set; }

    }
}
