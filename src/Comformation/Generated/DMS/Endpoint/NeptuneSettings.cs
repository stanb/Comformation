using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint NeptuneSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-neptunesettings.html
    /// </summary>
    public class NeptuneSettings
    {

        /// <summary>
        /// MaxRetryCount
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxRetryCount")]
        public Union<int, IntrinsicFunction> MaxRetryCount { get; set; }

        /// <summary>
        /// MaxFileSize
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxFileSize")]
        public Union<int, IntrinsicFunction> MaxFileSize { get; set; }

        /// <summary>
        /// S3BucketFolder
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketFolder")]
        public Union<string, IntrinsicFunction> S3BucketFolder { get; set; }

        /// <summary>
        /// ErrorRetryDuration
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorRetryDuration")]
        public Union<int, IntrinsicFunction> ErrorRetryDuration { get; set; }

        /// <summary>
        /// IamAuthEnabled
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamAuthEnabled")]
        public Union<bool, IntrinsicFunction> IamAuthEnabled { get; set; }

        /// <summary>
        /// S3BucketName
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

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
