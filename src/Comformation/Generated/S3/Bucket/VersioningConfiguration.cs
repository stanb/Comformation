using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket VersioningConfiguration
    /// Describes the versioning state of an Amazon S3 bucket. For more information, see PUT Bucket versioning in the
    /// Amazon Simple Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-versioningconfig.html
    /// </summary>
    public class VersioningConfiguration
    {

        /// <summary>
        /// Status
        /// The versioning state of the bucket.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Enabled | Suspended
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
