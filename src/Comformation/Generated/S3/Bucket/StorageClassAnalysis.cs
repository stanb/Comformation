using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket StorageClassAnalysis
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-storageclassanalysis.html
    /// </summary>
    public class StorageClassAnalysis
    {

        /// <summary>
        /// DataExport
        /// Specifies how data related to the storage class analysis for an Amazon S3 bucket should be exported.
        /// Required: No
        /// Type: DataExport
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataExport")]
        public DataExport DataExport { get; set; }

    }
}
