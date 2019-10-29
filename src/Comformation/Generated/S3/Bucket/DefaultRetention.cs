using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket DefaultRetention
    /// The default retention period that you want to apply to new objects placed in the specified bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html
    /// </summary>
    public class DefaultRetention
    {

        /// <summary>
        /// Days
        /// The number of days that you want to specify for the default retention period.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Days")]
        public Union<int, IntrinsicFunction> Days { get; set; }

        /// <summary>
        /// Mode
        /// The default Object Lock retention mode you want to apply to new objects placed in the specified
        /// bucket.
        /// Required: No
        /// Type: String
        /// Allowed Values: COMPLIANCE | GOVERNANCE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// Years
        /// The number of years that you want to specify for the default retention period.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Years")]
        public Union<int, IntrinsicFunction> Years { get; set; }

    }
}
