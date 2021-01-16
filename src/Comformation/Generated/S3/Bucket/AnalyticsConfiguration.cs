using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket AnalyticsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-analyticsconfiguration.html
    /// </summary>
    public class AnalyticsConfiguration
    {

        /// <summary>
        /// Id
        /// The ID that identifies the analytics configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Prefix
        /// The prefix that an object must have to be included in the analytics results.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// StorageClassAnalysis
        /// Contains data related to access patterns to be collected and made available to analyze the tradeoffs
        /// between different storage classes.
        /// Required: Yes
        /// Type: StorageClassAnalysis
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageClassAnalysis")]
        public StorageClassAnalysis StorageClassAnalysis { get; set; }

        /// <summary>
        /// TagFilters
        /// The tags to use when evaluating an analytics filter.
        /// The analytics only includes objects that meet the filter&#39;s criteria. If no filter is specified, all
        /// of the contents of the bucket are included in the analysis.
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

    }
}
