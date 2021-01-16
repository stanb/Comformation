using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket Tiering
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tiering.html
    /// </summary>
    public class Tiering
    {

        /// <summary>
        /// AccessTier
        /// S3 Intelligent-Tiering access tier. See Storage class for automatically optimizing frequently and
        /// infrequently accessed objects for a list of access tiers in the S3 Intelligent-Tiering storage
        /// class.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ARCHIVE_ACCESS | DEEP_ARCHIVE_ACCESS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessTier")]
        public Union<string, IntrinsicFunction> AccessTier { get; set; }

        /// <summary>
        /// Days
        /// The number of consecutive days of no access after which an object will be eligible to be
        /// transitioned to the corresponding tier. The minimum number of days specified for Archive Access tier
        /// must be at least 90 days and Deep Archive Access tier must be at least 180 days. The maximum can be
        /// up to 2 years (730 days).
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Days")]
        public Union<int, IntrinsicFunction> Days { get; set; }

    }
}
