using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket MetricsConfiguration
    /// Specifies a metrics configuration for the CloudWatch request metrics (specified by the metrics configuration
    /// ID) from an Amazon S3 bucket. If you&#39;re updating an existing metrics configuration, note that this is a full
    /// replacement of the existing metrics configuration. If you don&#39;t include the elements you want to keep, they
    /// are erased. For more information, see PUT Bucket metrics in the Amazon Simple Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html
    /// </summary>
    public class MetricsConfiguration
    {

        /// <summary>
        /// Id
        /// The ID used to identify the metrics configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Prefix
        /// The prefix that an object must have to be included in the metrics results.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// TagFilters
        /// Specifies a list of tag filters to use as a metrics configuration filter. The metrics configuration
        /// includes only objects that meet the filter&#39;s criteria.
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

    }
}
