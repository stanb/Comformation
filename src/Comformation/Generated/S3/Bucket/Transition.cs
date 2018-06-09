using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket Transition
    /// Describes when an object transitions to a specified storage class for the Amazon S3 Bucket Rule property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-transition.html
    /// </summary>
    public class Transition
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
        /// TransitionDate
        /// Indicates when objects are transitioned to the specified storage class. The date value must be in
        /// ISO 8601 format. The time is always midnight UTC.
        /// Required: Conditional
        /// Type: String
        /// </summary>
        [JsonProperty("TransitionDate")]
        public Union<string, IntrinsicFunction> TransitionDate { get; set; }

        /// <summary>
        /// TransitionInDays
        /// Indicates the number of days after creation when objects are transitioned to the specified storage
        /// class.
        /// Required: Conditional
        /// Type: Integer
        /// </summary>
        [JsonProperty("TransitionInDays")]
        public Union<int, IntrinsicFunction> TransitionInDays { get; set; }

    }
}
