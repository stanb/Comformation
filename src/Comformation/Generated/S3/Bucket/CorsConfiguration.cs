using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket CorsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors.html
    /// </summary>
    public class CorsConfiguration
    {

        /// <summary>
        /// CorsRules
        /// A set of origins and methods (cross-origin access that you want to allow). You can add up to 100
        /// rules to the configuration.
        /// Required: Yes
        /// Type: List of CorsRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CorsRules")]
        public List<CorsRule> CorsRules { get; set; }

    }
}
