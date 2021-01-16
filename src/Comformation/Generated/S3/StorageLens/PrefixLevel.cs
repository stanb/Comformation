using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens PrefixLevel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevel.html
    /// </summary>
    public class PrefixLevel
    {

        /// <summary>
        /// StorageMetrics
        /// A property for the prefix-level storage metrics for Amazon S3 Storage Lens.
        /// Required: Yes
        /// Type: PrefixLevelStorageMetrics
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageMetrics")]
        public PrefixLevelStorageMetrics StorageMetrics { get; set; }

    }
}
