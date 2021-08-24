using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket DefaultRetention
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-defaultretention.html
    /// </summary>
    public class DefaultRetention
    {

        /// <summary>
        /// Days
        /// The number of days that you want to specify for the default retention period. If Object Lock is
        /// turned on, you must specify Mode and specify either Days or Years.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Days")]
        public Union<int, IntrinsicFunction> Days { get; set; }

        /// <summary>
        /// Mode
        /// The default Object Lock retention mode you want to apply to new objects placed in the specified
        /// bucket. If Object Lock is turned on, you must specify Mode and specify either Days or Years.
        /// Required: Conditional
        /// Type: String
        /// Allowed values: COMPLIANCE | GOVERNANCE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

        /// <summary>
        /// Years
        /// The number of years that you want to specify for the default retention period. If Object Lock is
        /// turned on, you must specify Mode and specify either Days or Years.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Years")]
        public Union<int, IntrinsicFunction> Years { get; set; }

    }
}
