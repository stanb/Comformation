using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens BucketLevel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketlevel.html
    /// </summary>
    public class BucketLevel
    {

        /// <summary>
        /// ActivityMetrics
        /// A property for the bucket-level activity metrics for Amazon S3 Storage Lens.
        /// Required: No
        /// Type: ActivityMetrics
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActivityMetrics")]
        public ActivityMetrics ActivityMetrics { get; set; }

        /// <summary>
        /// PrefixLevel
        /// A property for the bucket-level prefix-level storage metrics for S3 Storage Lens.
        /// Required: No
        /// Type: PrefixLevel
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrefixLevel")]
        public PrefixLevel PrefixLevel { get; set; }

    }
}
