using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.Bucket
{
    /// <summary>
    /// AWS::S3Outposts::Bucket LifecycleConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3outposts-bucket-lifecycleconfiguration.html
    /// </summary>
    public class LifecycleConfiguration
    {

        /// <summary>
        /// Rules
        /// The container for the lifecycle configuration rules for the objects stored in the S3 on Outposts
        /// bucket.
        /// Required: Yes
        /// Type: List of Rule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<Rule> Rules { get; set; }

    }
}
