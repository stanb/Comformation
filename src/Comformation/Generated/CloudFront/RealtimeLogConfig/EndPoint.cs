using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.RealtimeLogConfig
{
    /// <summary>
    /// AWS::CloudFront::RealtimeLogConfig EndPoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-realtimelogconfig-endpoint.html
    /// </summary>
    public class EndPoint
    {

        /// <summary>
        /// KinesisStreamConfig
        /// 		
        /// Contains information about the Amazon Kinesis data stream where you are sending 			real-time log
        /// data.
        /// 	
        /// Required: Yes
        /// Type: KinesisStreamConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisStreamConfig")]
        public KinesisStreamConfig KinesisStreamConfig { get; set; }

        /// <summary>
        /// StreamType
        /// 		
        /// The type of data stream where you are sending real-time log data. The only valid value is
        /// 			Kinesis.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamType")]
        public Union<string, IntrinsicFunction> StreamType { get; set; }

    }
}
