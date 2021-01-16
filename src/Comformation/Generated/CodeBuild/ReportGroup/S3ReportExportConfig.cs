using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.ReportGroup
{
    /// <summary>
    /// AWS::CodeBuild::ReportGroup S3ReportExportConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html
    /// </summary>
    public class S3ReportExportConfig
    {

        /// <summary>
        /// Path
        /// The path to the exported report&#39;s raw data results.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Bucket
        /// The name of the S3 bucket where the raw data of a report are exported.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Packaging
        /// The type of build output artifact to create. Valid values include:
        /// NONE: AWS CodeBuild creates the raw data in the output bucket. This is the default if packaging is
        /// not specified. ZIP: AWS CodeBuild creates a ZIP file with the raw data in the output bucket.
        /// Required: No
        /// Type: String
        /// Allowed values: NONE | ZIP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Packaging")]
        public Union<string, IntrinsicFunction> Packaging { get; set; }

        /// <summary>
        /// EncryptionKey
        /// The encryption key for the report&#39;s encrypted raw data.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionKey")]
        public Union<string, IntrinsicFunction> EncryptionKey { get; set; }

        /// <summary>
        /// EncryptionDisabled
        /// A boolean value that specifies if the results of a report are encrypted.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionDisabled")]
        public Union<bool, IntrinsicFunction> EncryptionDisabled { get; set; }

    }
}
