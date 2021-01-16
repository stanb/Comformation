using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket NoncurrentVersionTransition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition.html
    /// </summary>
    public class NoncurrentVersionTransition
    {

        /// <summary>
        /// StorageClass
        /// The class of storage used to store the object.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DEEP_ARCHIVE | GLACIER | INTELLIGENT_TIERING | ONEZONE_IA | STANDARD_IA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageClass")]
        public Union<string, IntrinsicFunction> StorageClass { get; set; }

        /// <summary>
        /// TransitionInDays
        /// Specifies the number of days an object is noncurrent before Amazon S3 can perform the associated
        /// action. For information about the noncurrent days calculations, see How Amazon S3 Calculates How
        /// Long an Object Has Been Noncurrent in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitionInDays")]
        public Union<int, IntrinsicFunction> TransitionInDays { get; set; }

    }
}
