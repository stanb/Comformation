using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint KinesisSettings
    /// Syntax
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html
    /// </summary>
    public class KinesisSettings
    {

        /// <summary>
        /// MessageFormat
        /// The output format for the records created on the endpoint. The message format is JSON.
        /// Required: No
        /// Type: String
        /// Allowed Values: json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageFormat")]
        public Union<string, IntrinsicFunction> MessageFormat { get; set; }

        /// <summary>
        /// StreamArn
        /// The Amazon Resource Name (ARN) for the Amazon Kinesis Data Streams endpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamArn")]
        public Union<string, IntrinsicFunction> StreamArn { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// The Amazon Resource Name (ARN) for the IAM role that DMS uses to write to the Amazon Kinesis data
        /// stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
