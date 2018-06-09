using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket NoncurrentVersionTransition
    /// NoncurrentVersionTransition is a property of the Amazon S3 Bucket Rule property that describes when noncurrent
    /// objects transition to a specified storage class.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition.html
    /// </summary>
    public class NoncurrentVersionTransition
    {

        /// <summary>
        /// StorageClass
        /// The storage class to which you want the object to transition, such as GLACIER. For valid values, see
        /// the StorageClass request element of the PUT Bucket lifecycle action in the Amazon Simple Storage
        /// Service API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StorageClass")]
        public Union<string, IntrinsicFunction> StorageClass { get; set; }

        /// <summary>
        /// TransitionInDays
        /// The number of days between the time that a new version of the object is uploaded to the bucket and
        /// when old versions of the object are transitioned to the specified storage class.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("TransitionInDays")]
        public Union<int, IntrinsicFunction> TransitionInDays { get; set; }

    }
}
