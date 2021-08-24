using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint KinesisSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html
    /// </summary>
    public class KinesisSettings
    {

        /// <summary>
        /// MessageFormat
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Allowed values: json | json-unformatted
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageFormat")]
        public Union<string, IntrinsicFunction> MessageFormat { get; set; }

        /// <summary>
        /// StreamArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamArn")]
        public Union<string, IntrinsicFunction> StreamArn { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
