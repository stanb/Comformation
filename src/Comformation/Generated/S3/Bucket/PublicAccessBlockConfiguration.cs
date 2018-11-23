using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon Simple Storage Service Bucket PublicAccessBlockConfiguration
    /// The PublicAccessBlockConfiguration property type specifies the public access configuration for an Amazon S3
    /// bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html
    /// </summary>
    public class PublicAccessBlockConfiguration
    {

        /// <summary>
        /// BlockPublicAcls
        /// Specifies whether Amazon S3 will reject public ACLs for this bucket.
        /// Enabling this setting has no effect on existing policies or ACLs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockPublicAcls")]
        public Union<bool, IntrinsicFunction> BlockPublicAcls { get; set; }

        /// <summary>
        /// BlockPublicPolicy
        /// Specifies whether Amazon S3 will block public bucket policies for this bucket.
        /// Enabling this setting has no effect on existing policies.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockPublicPolicy")]
        public Union<bool, IntrinsicFunction> BlockPublicPolicy { get; set; }

        /// <summary>
        /// IgnorePublicAcls
        /// Specifies whether Amazon S3 will ignore public ACLs for this bucket.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnorePublicAcls")]
        public Union<bool, IntrinsicFunction> IgnorePublicAcls { get; set; }

        /// <summary>
        /// RestrictPublicBuckets
        /// Specifies whether Amazon S3 will lock down public bucket policies for this bucket.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestrictPublicBuckets")]
        public Union<bool, IntrinsicFunction> RestrictPublicBuckets { get; set; }

    }
}
