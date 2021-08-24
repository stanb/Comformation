using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table KinesisStreamSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-kinesisstreamspecification.html
    /// </summary>
    public class KinesisStreamSpecification
    {

        /// <summary>
        /// StreamArn
        /// 	
        /// The ARN for a specific Kinesis data stream.
        /// 	
        /// Length Constraints: Minimum length of 37. Maximum length of 1024.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamArn")]
        public Union<string, IntrinsicFunction> StreamArn { get; set; }

    }
}
