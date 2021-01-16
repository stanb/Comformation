using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens PrefixLevelStorageMetrics
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-prefixlevelstoragemetrics.html
    /// </summary>
    public class PrefixLevelStorageMetrics
    {

        /// <summary>
        /// IsEnabled
        /// This property identifies whether the details of the prefix-level storage metrics for S3 Storage Lens
        /// are enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsEnabled")]
        public Union<bool, IntrinsicFunction> IsEnabled { get; set; }

        /// <summary>
        /// SelectionCriteria
        /// This property identifies whether the details of the prefix-level storage metrics for S3 Storage Lens
        /// are enabled.
        /// Required: No
        /// Type: SelectionCriteria
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectionCriteria")]
        public SelectionCriteria SelectionCriteria { get; set; }

    }
}
