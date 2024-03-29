using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// AbortIncompleteMultipartUpload
        /// Specifies a lifecycle rule that stops incomplete multipart uploads to an Amazon S3 bucket.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: AbortIncompleteMultipartUpload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbortIncompleteMultipartUpload")]
        public AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload { get; set; }

        /// <summary>
        /// ExpirationDate
        /// Indicates when objects are deleted from Amazon S3 and Amazon S3 Glacier. The date value must be in
        /// ISO 8601 format. The time is always midnight UTC. If you specify an expiration and transition time,
        /// you must use the same time unit for both properties (either in days or by date). The expiration time
        /// must also be later than the transition time.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: Timestamp
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public Union<string, IntrinsicFunction> ExpirationDate { get; set; }

        /// <summary>
        /// ExpirationInDays
        /// Indicates the number of days after creation when objects are deleted from Amazon S3 and Amazon S3
        /// Glacier. If you specify an expiration and transition time, you must use the same time unit for both
        /// properties (either in days or by date). The expiration time must also be later than the transition
        /// time.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpirationInDays")]
        public Union<int, IntrinsicFunction> ExpirationInDays { get; set; }

        /// <summary>
        /// ExpiredObjectDeleteMarker
        /// Indicates whether Amazon S3 will remove a delete marker without any noncurrent versions. If set to
        /// true, the delete marker will be removed if there are no noncurrent versions. This cannot be
        /// specified with ExpirationInDays, ExpirationDate, or TagFilters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpiredObjectDeleteMarker")]
        public Union<bool, IntrinsicFunction> ExpiredObjectDeleteMarker { get; set; }

        /// <summary>
        /// Id
        /// Unique identifier for the rule. The value can&#39;t be longer than 255 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// NoncurrentVersionExpirationInDays
        /// For buckets with versioning enabled (or suspended), specifies the time, in days, between when a new
        /// version of the object is uploaded to the bucket and when old versions of the object expire. When
        /// object versions expire, Amazon S3 permanently deletes them. If you specify a transition and
        /// expiration time, the expiration time must be later than the transition time.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoncurrentVersionExpirationInDays")]
        public Union<int, IntrinsicFunction> NoncurrentVersionExpirationInDays { get; set; }

        /// <summary>
        /// NoncurrentVersionTransition
        /// (Deprecated. ) For buckets with versioning enabled (or suspended), specifies when non-current
        /// objects transition to a specified storage class. If you specify a transition and expiration time,
        /// the expiration time must be later than the transition time. If you specify this property, don&#39;t
        /// specify the NoncurrentVersionTransitions property.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: NoncurrentVersionTransition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoncurrentVersionTransition")]
        public NoncurrentVersionTransition NoncurrentVersionTransition { get; set; }

        /// <summary>
        /// NoncurrentVersionTransitions
        /// For buckets with versioning enabled (or suspended), one or more transition rules that specify when
        /// non-current objects transition to a specified storage class. If you specify a transition and
        /// expiration time, the expiration time must be later than the transition time. If you specify this
        /// property, don&#39;t specify the NoncurrentVersionTransition property.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: List of NoncurrentVersionTransition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoncurrentVersionTransitions")]
        public List<NoncurrentVersionTransition> NoncurrentVersionTransitions { get; set; }

        /// <summary>
        /// Prefix
        /// Object key prefix that identifies one or more objects to which this rule applies.
        /// Important Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see XML related object key constraints.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Status
        /// If Enabled, the rule is currently being applied. If Disabled, the rule is not currently being
        /// applied.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// TagFilters
        /// Tags to use to identify a subset of objects to which the lifecycle rule applies.
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

        /// <summary>
        /// Transition
        /// (Deprecated. ) Specifies when an object transitions to a specified storage class. If you specify an
        /// expiration and transition time, you must use the same time unit for both properties (either in days
        /// or by date). The expiration time must also be later than the transition time. If you specify this
        /// property, don&#39;t specify the Transitions property.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: Transition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Transition")]
        public Transition Transition { get; set; }

        /// <summary>
        /// Transitions
        /// One or more transition rules that specify when an object transitions to a specified storage class.
        /// If you specify an expiration and transition time, you must use the same time unit for both
        /// properties (either in days or by date). The expiration time must also be later than the transition
        /// time. If you specify this property, don&#39;t specify the Transition property.
        /// You must specify at least one of the following properties: AbortIncompleteMultipartUpload,
        /// ExpirationDate, ExpirationInDays, NoncurrentVersionExpirationInDays, NoncurrentVersionTransition,
        /// NoncurrentVersionTransitions, Transition, or Transitions.
        /// Required: Conditional
        /// Type: List of Transition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Transitions")]
        public List<Transition> Transitions { get; set; }

    }
}
