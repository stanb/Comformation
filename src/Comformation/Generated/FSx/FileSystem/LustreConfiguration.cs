using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem LustreConfiguration
    /// The configuration for the Amazon FSx for Lustre file system.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html
    /// </summary>
    public class LustreConfiguration
    {

        /// <summary>
        /// ImportPath
        /// The path to the Amazon S3 bucket (including the optional prefix) that you&#39;re using as the data
        /// repository for your Amazon FSx for Lustre file system. The root of your FSx for Lustre file system
        /// will be mapped to the root of the Amazon S3 bucket you select. An example is
        /// s3://import-bucket/optional-prefix. If you specify a prefix after the Amazon S3 bucket name, only
        /// object keys with that prefix are loaded into the file system.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 900
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImportPath")]
        public Union<string, IntrinsicFunction> ImportPath { get; set; }

        /// <summary>
        /// WeeklyMaintenanceStartTime
        /// The preferred time to perform weekly maintenance, in the UTC time zone.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeeklyMaintenanceStartTime")]
        public Union<string, IntrinsicFunction> WeeklyMaintenanceStartTime { get; set; }

        /// <summary>
        /// ImportedFileChunkSize
        /// For files imported from a data repository, this value determines the stripe count and maximum amount
        /// of data per file (in MiB) stored on a single physical disk. The maximum number of disks that a
        /// single file can be striped across is limited by the total number of disks that make up the file
        /// system.
        /// The chunk size default is 1,024 MiB (1 GiB) and can go as high as 512,000 MiB (500 GiB). Amazon S3
        /// objects have a maximum size of 5 TB.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 512000
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImportedFileChunkSize")]
        public Union<int, IntrinsicFunction> ImportedFileChunkSize { get; set; }

        /// <summary>
        /// ExportPath
        /// The path in Amazon S3 where the root of your Amazon FSx file system is exported. The path must use
        /// the same Amazon S3 bucket as specified in ImportPath. You can provide an optional prefix to which
        /// new and changed data is to be exported from your Amazon FSx for Lustre file system. If an ExportPath
        /// value is not provided, Amazon FSx sets a default export path,
        /// s3://import-bucket/FSxLustre[creation-timestamp]. The timestamp is in UTC format, for example
        /// s3://import-bucket/FSxLustre20181105T222312Z.
        /// The Amazon S3 export bucket must be the same as the import bucket specified by ImportPath. If you
        /// only specify a bucket name, such as s3://import-bucket, you get a 1:1 mapping of file system objects
        /// to S3 bucket objects. This mapping means that the input data in S3 is overwritten on export. If you
        /// provide a custom prefix in the export path, such as s3://import-bucket/[custom-optional-prefix],
        /// Amazon FSx exports the contents of your file system to that export prefix in the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 900
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExportPath")]
        public Union<string, IntrinsicFunction> ExportPath { get; set; }

    }
}
