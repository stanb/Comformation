using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket AnalyticsConfiguration
    /// The AnalyticsConfiguration property type specifies the configuration and any analyses for the analytics filter
    /// of an Amazon S3 bucket.
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
        /// Type: Amazon S3 Bucket StorageClassAnalysis
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageClassAnalysis")]
        public Union<StorageClassAnalysis, IntrinsicFunction> StorageClassAnalysis { get; set; }

        /// <summary>
        /// TagFilters
        /// The tags to use when evaluating an analytics filter.
        /// The analytics only includes objects that meet the filter&#39;s criteria. If no filter is speciified, all
        /// of the contents of the bucket are included in the analysis.
        /// Required: No
        /// Type: List of Amazon S3 Bucket TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public Union<List<TagFilter>, IntrinsicFunction> TagFilters { get; set; }

    }
}
