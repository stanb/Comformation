using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket StorageClassAnalysis
    /// The StorageClassAnalysis property type specifies data related to access patterns to be collected and made
    /// available to analyze the tradeoffs between different storage classes for an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-storageclassanalysis.html
    /// </summary>
    public class StorageClassAnalysis
    {

        /// <summary>
        /// DataExport
        /// Describes how data related to the storage class analysis should be exported.
        /// Required: No
        /// Type: DataExport
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataExport")]
        public DataExport DataExport { get; set; }

    }
}
