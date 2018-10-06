using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket LifecycleConfiguration
    /// Describes the lifecycle configuration for objects in an AWS::S3::Bucket resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig.html
    /// </summary>
    public class LifecycleConfiguration
    {

        /// <summary>
        /// Rules
        /// A lifecycle rule for individual objects in an S3 bucket.
        /// Required: Yes
        /// Type: Amazon S3 Bucket Rule
        /// </summary>
        [JsonProperty("Rules")]
        public List<Rule> Rules { get; set; }

    }
}
