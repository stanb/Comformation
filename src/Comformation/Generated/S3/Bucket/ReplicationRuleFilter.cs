using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationRuleFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationrulefilter.html
    /// </summary>
    public class ReplicationRuleFilter
    {

        /// <summary>
        /// And
        /// A container for specifying rule filters. The filters determine the subset of objects to which the
        /// rule applies. This element is required only if you specify more than one filter. For example:
        /// If you specify both a Prefix and a TagFilter, wrap these filters in an And tag. If you specify a
        /// filter based on multiple tags, wrap the TagFilter elements in an And tag.
        /// Required: No
        /// Type: ReplicationRuleAndOperator
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("And")]
        public ReplicationRuleAndOperator And { get; set; }

        /// <summary>
        /// Prefix
        /// An object key name prefix that identifies the subset of objects to which the rule applies.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// TagFilter
        /// A container for specifying a tag key and value.
        /// The rule applies only to objects that have the tag in their tag set.
        /// Required: No
        /// Type: TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilter")]
        public TagFilter TagFilter { get; set; }

    }
}
