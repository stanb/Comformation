using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens AccountLevel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-accountlevel.html
    /// </summary>
    public class AccountLevel
    {

        /// <summary>
        /// ActivityMetrics
        /// This property contains the details of the account-level activity metrics for Amazon S3 Storage Lens.
        /// Required: No
        /// Type: ActivityMetrics
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActivityMetrics")]
        public ActivityMetrics ActivityMetrics { get; set; }

        /// <summary>
        /// BucketLevel
        /// This property contains the details of the account-level bucket-level configurations for Amazon S3
        /// Storage Lens.
        /// Required: Yes
        /// Type: BucketLevel
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketLevel")]
        public BucketLevel BucketLevel { get; set; }

    }
}
