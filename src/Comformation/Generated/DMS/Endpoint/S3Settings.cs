using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS DMS Endpoint S3Settings
    /// Use the S3Settings property to specify settings for an Amazon S3 endpoint for a AWS::DMS::Endpoint resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-s3settings.html
    /// </summary>
    public class S3Settings
    {

        /// <summary>
        /// ExternalTableDefinition
        /// The definition of the external table.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ExternalTableDefinition")]
        public Union<string, IntrinsicFunction> ExternalTableDefinition { get; set; }

        /// <summary>
        /// BucketName
        /// The name of the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketFolder
        /// An optional parameter to set a folder name in the S3 bucket. If provided, tables are created in the
        /// path &lt;bucketFolder&gt;/&lt;schema_name&gt;/&lt;table_name&gt;/. If this parameter is not
        /// specified, then the path used is &lt;schema_name&gt;/&lt;table_name&gt;/.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("BucketFolder")]
        public Union<string, IntrinsicFunction> BucketFolder { get; set; }

        /// <summary>
        /// CsvRowDelimiter
        /// The delimiter used to separate rows in the source files. The default is a carriage return (\n).
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CsvRowDelimiter")]
        public Union<string, IntrinsicFunction> CsvRowDelimiter { get; set; }

        /// <summary>
        /// CsvDelimiter
        /// The delimiter used to separate columns in the source files. The default is a comma.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CsvDelimiter")]
        public Union<string, IntrinsicFunction> CsvDelimiter { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// The Amazon Resource Name (ARN) used by the service access IAM role.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// CompressionType
        /// An optional parameter to use GZIP to compress the target files. Set to GZIP to compress the target
        /// files. Set to NONE (the default) or do not use to leave the files uncompressed.
        /// Valid Values: NONE | GZIP
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CompressionType")]
        public Union<string, IntrinsicFunction> CompressionType { get; set; }

    }
}
