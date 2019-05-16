using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket Transition
    /// Specifies when an object transitions to a specified storage class.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-transition.html
    /// </summary>
    public class Transition
    {

        /// <summary>
        /// StorageClass
        /// The storage class to which you want the object to transition.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: DEEP_ARCHIVE | GLACIER | INTELLIGENT_TIERING | ONEZONE_IA | STANDARD_IA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageClass")]
        public Union<string, IntrinsicFunction> StorageClass { get; set; }

        /// <summary>
        /// TransitionDate
        /// Indicates when objects are transitioned to the specified storage class. The date value must be in
        /// ISO 8601 format. The time is always midnight UTC.
        /// Required: Conditional
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitionDate")]
        public Union<string, IntrinsicFunction> TransitionDate { get; set; }

        /// <summary>
        /// TransitionInDays
        /// Indicates the number of days after creation when objects are transitioned to the specified storage
        /// class. The value must be a positive integer.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitionInDays")]
        public Union<int, IntrinsicFunction> TransitionInDays { get; set; }

    }
}
