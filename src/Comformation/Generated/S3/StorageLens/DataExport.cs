using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens DataExport
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-dataexport.html
    /// </summary>
    public class DataExport
    {

        /// <summary>
        /// S3BucketDestination
        /// This property contains the details of the bucket where the S3 Storage Lens metrics export will be
        /// placed.
        /// Required: Yes
        /// Type: S3BucketDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketDestination")]
        public S3BucketDestination S3BucketDestination { get; set; }

    }
}
