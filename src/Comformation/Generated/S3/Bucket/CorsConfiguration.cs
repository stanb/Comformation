using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket CorsConfiguration
    /// Describes the cross-origin access configuration for objects in an AWS::S3::Bucket resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors.html
    /// </summary>
    public class CorsConfiguration
    {

        /// <summary>
        /// CorsRules
        /// A set of origins and methods that you allow.
        /// Required: Yes
        /// Type: Amazon S3 Bucket CorsRule
        /// </summary>
        [JsonProperty("CorsRules")]
        public Union<List<CorsRule>, IntrinsicFunction> CorsRules { get; set; }

    }
}
