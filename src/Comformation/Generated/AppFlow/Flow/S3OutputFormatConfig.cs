using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow S3OutputFormatConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html
    /// </summary>
    public class S3OutputFormatConfig
    {

        /// <summary>
        /// FileType
        /// Indicates the file type that Amazon AppFlow places in the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Allowed values: CSV | JSON | PARQUET
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileType")]
        public Union<string, IntrinsicFunction> FileType { get; set; }

        /// <summary>
        /// PrefixConfig
        /// Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon S3 bucket. You
        /// can name folders according to the flow frequency and date.
        /// Required: No
        /// Type: PrefixConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrefixConfig")]
        public PrefixConfig PrefixConfig { get; set; }

        /// <summary>
        /// AggregationConfig
        /// The aggregation settings that you can use to customize the output format of your flow data.
        /// Required: No
        /// Type: AggregationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AggregationConfig")]
        public AggregationConfig AggregationConfig { get; set; }

    }
}
