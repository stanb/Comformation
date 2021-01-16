using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens BucketsAndRegions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html
    /// </summary>
    public class BucketsAndRegions
    {

        /// <summary>
        /// Buckets
        /// This property contains the details of the buckets for the Amazon S3 Storage Lens configuration. This
        /// should be the bucket Amazon Resource Name(ARN). For valid values, see Buckets ARN format here in the
        /// Amazon Simple Storage Service API Guide.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Buckets")]
        public List<Union<string, IntrinsicFunction>> Buckets { get; set; }

        /// <summary>
        /// Regions
        /// This property contains the details of the Regions for the S3 Storage Lens configuration.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regions")]
        public List<Union<string, IntrinsicFunction>> Regions { get; set; }

    }
}
