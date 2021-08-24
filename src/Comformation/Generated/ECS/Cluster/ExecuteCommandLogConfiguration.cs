using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster ExecuteCommandLogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandlogconfiguration.html
    /// </summary>
    public class ExecuteCommandLogConfiguration
    {

        /// <summary>
        /// CloudWatchLogGroupName
        /// 		
        /// The name of the CloudWatch log group to send logs to.
        /// 		
        /// Note The CloudWatch log group must already be created.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogGroupName")]
        public Union<string, IntrinsicFunction> CloudWatchLogGroupName { get; set; }

        /// <summary>
        /// CloudWatchEncryptionEnabled
        /// 		
        /// Whether or not to enable encryption on the CloudWatch logs. If not specified, 			encryption will be
        /// disabled.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchEncryptionEnabled")]
        public Union<bool, IntrinsicFunction> CloudWatchEncryptionEnabled { get; set; }

        /// <summary>
        /// S3BucketName
        /// 		
        /// The name of the S3 bucket to send logs to.
        /// 		
        /// Note The S3 bucket must already be created.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

        /// <summary>
        /// S3EncryptionEnabled
        /// 		
        /// Whether or not to enable encryption on the CloudWatch logs. If not specified, 			encryption will be
        /// disabled.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3EncryptionEnabled")]
        public Union<bool, IntrinsicFunction> S3EncryptionEnabled { get; set; }

        /// <summary>
        /// S3KeyPrefix
        /// 		
        /// An optional folder in the S3 bucket to place logs in.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3KeyPrefix")]
        public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

    }
}
