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
        /// The external table definition.
        /// Conditional: If S3 is used as a source then ExternalTableDefinition is required.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExternalTableDefinition")]
        public Union<string, IntrinsicFunction> ExternalTableDefinition { get; set; }

        /// <summary>
        /// BucketName
        /// The name of the S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketFolder
        /// An optional parameter to set a folder name in the S3 bucket. If provided, tables are created in the
        /// path bucketFolder/schema_name/table_name/. If this parameter isn&#39;t specified, then the path used is
        /// schema_name/table_name/.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketFolder")]
        public Union<string, IntrinsicFunction> BucketFolder { get; set; }

        /// <summary>
        /// CsvRowDelimiter
        /// The delimiter used to separate rows in the . csv file for both source and target. The default is a
        /// carriage return (\n).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CsvRowDelimiter")]
        public Union<string, IntrinsicFunction> CsvRowDelimiter { get; set; }

        /// <summary>
        /// CsvDelimiter
        /// The delimiter used to separate columns in the . csv file for both source and target. The default is
        /// a comma.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CsvDelimiter")]
        public Union<string, IntrinsicFunction> CsvDelimiter { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// The Amazon Resource Name (ARN) used by the service access IAM role. It is a required parameter that
        /// enables DMS to write and read objects from an 3S bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// CompressionType
        /// An optional parameter to use GZIP to compress the target files. Set to GZIP to compress the target
        /// files. Either set this parameter to NONE (the default) or don&#39;t use it to leave the files
        /// uncompressed. This parameter applies to both . csv and . parquet file formats.
        /// Required: No
        /// Type: String
        /// Allowed values: gzip | none
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CompressionType")]
        public Union<string, IntrinsicFunction> CompressionType { get; set; }

    }
}
