using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket Rule
    /// The Rule property type describes lifecycle rules. The Rules subproperty of the Amazon S3 Bucket
    /// LifecycleConfiguration property contains a list of Rule property types. For more information, see PUT Bucket
    /// lifecycle in the Amazon Simple Storage Service (Amazon S3) API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// AbortIncompleteMultipartUpload
        /// Specifies a lifecycle rule that aborts incomplete multipart uploads to an Amazon S3 bucket.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: Amazon S3 Bucket AbortIncompleteMultipartUpload
        /// </summary>
        [JsonProperty("AbortIncompleteMultipartUpload")]
        public Union<AbortIncompleteMultipartUpload, IntrinsicFunction> AbortIncompleteMultipartUpload { get; set; }

        /// <summary>
        /// ExpirationDate
        /// Indicates when objects are deleted from Amazon S3 and Amazon Glacier. The date value must be in ISO
        /// 8601 format. The time is always midnight UTC. If you specify an expiration and transition time, you
        /// must use the same time unit for both properties (either in days or by date). The expiration time
        /// must also be later than the transition time.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: String
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public Union<string, IntrinsicFunction> ExpirationDate { get; set; }

        /// <summary>
        /// ExpirationInDays
        /// Indicates the number of days after creation when objects are deleted from Amazon S3 and Amazon
        /// Glacier. If you specify an expiration and transition time, you must use the same time unit for both
        /// properties (either in days or by date). The expiration time must also be later than the transition
        /// time.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: Integer
        /// </summary>
        [JsonProperty("ExpirationInDays")]
        public Union<int, IntrinsicFunction> ExpirationInDays { get; set; }

        /// <summary>
        /// Id
        /// A unique identifier for this rule. The value cannot be more than 255 characters.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// NoncurrentVersionExpirationInDays
        /// For buckets with versioning enabled (or suspended), specifies the time, in days, between when a new
        /// version of the object is uploaded to the bucket and when old versions of the object expire. When
        /// object versions expire, Amazon S3 permanently deletes them. If you specify a transition and
        /// expiration time, the expiration time must be later than the transition time.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: Integer
        /// </summary>
        [JsonProperty("NoncurrentVersionExpirationInDays")]
        public Union<int, IntrinsicFunction> NoncurrentVersionExpirationInDays { get; set; }

        /// <summary>
        /// NoncurrentVersionTransition
        /// For buckets with versioning enabled (or suspended), specifies when non-current objects transition to
        /// a specified storage class. If you specify a transition and expiration time, the expiration time must
        /// be later than the transition time. If you specify this property, don&#39;t specify the
        /// NoncurrentVersionTransitions property.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: Amazon S3 Bucket NoncurrentVersionTransition
        /// </summary>
        [JsonProperty("NoncurrentVersionTransition")]
        public Union<NoncurrentVersionTransition, IntrinsicFunction> NoncurrentVersionTransition { get; set; }

        /// <summary>
        /// NoncurrentVersionTransitions
        /// For buckets with versioning enabled (or suspended), one or more transition rules that specify when
        /// non-current objects transition to a specified storage class. If you specify a transition and
        /// expiration time, the expiration time must be later than the transition time. If you specify this
        /// property, don&#39;t specify the NoncurrentVersionTransition property.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: List of Amazon S3 Bucket NoncurrentVersionTransition
        /// </summary>
        [JsonProperty("NoncurrentVersionTransitions")]
        public Union<List<NoncurrentVersionTransition>, IntrinsicFunction> NoncurrentVersionTransitions { get; set; }

        /// <summary>
        /// Prefix
        /// Object key prefix that identifies one or more objects to which this rule applies.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Status
        /// Specify either Enabled or Disabled. If you specify Enabled, Amazon S3 executes this rule as
        /// scheduled. If you specify Disabled, Amazon S3 ignores this rule.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// TagFilters
        /// Tags to use to identify a subset of objects to which the lifecycle rule applies.
        /// Required: No
        /// Type: List of Amazon S3 Bucket TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public Union<List<TagFilter>, IntrinsicFunction> TagFilters { get; set; }

        /// <summary>
        /// Transition
        /// Specifies when an object transitions to a specified storage class. If you specify an expiration and
        /// transition time, you must use the same time unit for both properties (either in days or by date).
        /// The expiration time must also be later than the transition time. If you specify this property, don&#39;t
        /// specify the Transitions property.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: Amazon S3 Bucket Transition
        /// </summary>
        [JsonProperty("Transition")]
        public Union<Transition, IntrinsicFunction> Transition { get; set; }

        /// <summary>
        /// Transitions
        /// One or more transition rules that specify when an object transitions to a specified storage class.
        /// If you specify an expiration and transition time, you must use the same time unit for both
        /// properties (either in days or by date). The expiration time must also be later than the transition
        /// time. If you specify this property, don&#39;t specify the Transition property.
        /// Required: Conditional. You must specify at least one of the following properties:
        /// AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays,
        /// NoncurrentVersionTransition, NoncurrentVersionTransitions, Transition, or Transitions.
        /// Type: List of Amazon S3 Bucket Transition
        /// </summary>
        [JsonProperty("Transitions")]
        public Union<List<Transition>, IntrinsicFunction> Transitions { get; set; }

    }
}
