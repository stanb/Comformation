using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket LifecycleConfiguration
    /// Specifies the lifecycle configuration for objects in an Amazon S3 bucket. For more information, see Object
    /// Lifecycle Management in the Amazon Simple Storage Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig.html
    /// </summary>
    public class LifecycleConfiguration
    {

        /// <summary>
        /// Rules
        /// A lifecycle rule for individual objects in an Amazon S3 bucket.
        /// Required: Yes
        /// Type: List of Rule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<Rule> Rules { get; set; }

    }
}
