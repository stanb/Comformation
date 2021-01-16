using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens ActivityMetrics
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-activitymetrics.html
    /// </summary>
    public class ActivityMetrics
    {

        /// <summary>
        /// IsEnabled
        /// A property that indicates whether the activity metrics is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsEnabled")]
        public Union<bool, IntrinsicFunction> IsEnabled { get; set; }

    }
}
