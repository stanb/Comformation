using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.RealtimeLogConfig
{
    /// <summary>
    /// AWS::CloudFront::RealtimeLogConfig KinesisStreamConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-kinesisstreamconfig.html
    /// </summary>
    public class KinesisStreamConfig
    {

        /// <summary>
        /// RoleArn
        /// 		
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that
        /// 			CloudFront can use to send real-time log data to your Kinesis data stream.
        /// 		
        /// For more information the IAM role, see Real-time log configuration IAM role in the 			Amazon
        /// CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// StreamArn
        /// 		
        /// The Amazon Resource Name (ARN) of the Kinesis data stream where you are sending real-time 			log
        /// data.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamArn")]
        public Union<string, IntrinsicFunction> StreamArn { get; set; }

    }
}
