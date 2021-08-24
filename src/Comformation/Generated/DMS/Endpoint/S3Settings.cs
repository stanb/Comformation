using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint S3Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html
    /// </summary>
    public class S3Settings
    {

        /// <summary>
        /// ExternalTableDefinition
        /// Not currently supported by AWS CloudFormation.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExternalTableDefinition")]
        public Union<string, IntrinsicFunction> ExternalTableDefinition { get; set; }

        /// <summary>
        /// BucketName
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketFolder
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketFolder")]
        public Union<string, IntrinsicFunction> BucketFolder { get; set; }

        /// <summary>
        /// CsvRowDelimiter
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CsvRowDelimiter")]
        public Union<string, IntrinsicFunction> CsvRowDelimiter { get; set; }

        /// <summary>
        /// CsvDelimiter
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CsvDelimiter")]
        public Union<string, IntrinsicFunction> CsvDelimiter { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// CompressionType
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Allowed values: gzip | none
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CompressionType")]
        public Union<string, IntrinsicFunction> CompressionType { get; set; }

    }
}
