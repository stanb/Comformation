using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket NoncurrentVersionTransition
    /// Container for the transition rule that describes when noncurrent objects transition to the STANDARD_IA,
    /// ONEZONE_IA, INTELLIGENT_TIERING, GLACIER, or DEEP_ARCHIVE storage class. If your bucket is versioning-enabled
    /// (or versioning is suspended), you can set this action to request that Amazon S3 transition noncurrent object
    /// versions to the STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, GLACIER, or DEEP_ARCHIVE storage class at a
    /// specific period in the object&#39;s lifetime.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition.html
    /// </summary>
    public class NoncurrentVersionTransition
    {

        /// <summary>
        /// StorageClass
        /// The class of storage used to store the object.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: DEEP_ARCHIVE | GLACIER | INTELLIGENT_TIERING | ONEZONE_IA | STANDARD_IA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageClass")]
        public Union<string, IntrinsicFunction> StorageClass { get; set; }

        /// <summary>
        /// TransitionInDays
        /// Specifies the number of days an object is noncurrent before Amazon S3 can perform the associated
        /// action. For information about the noncurrent days calculations, see How Amazon S3 Calculates When an
        /// Object Became Noncurrent in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitionInDays")]
        public Union<int, IntrinsicFunction> TransitionInDays { get; set; }

    }
}
