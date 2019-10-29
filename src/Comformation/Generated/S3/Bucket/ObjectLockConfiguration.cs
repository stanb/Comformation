using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ObjectLockConfiguration
    /// Places an Object Lock configuration on the specified bucket. The rule specified in the Object Lock
    /// configuration will be applied by default to every new object placed in the specified bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockconfiguration.html
    /// </summary>
    public class ObjectLockConfiguration
    {

        /// <summary>
        /// ObjectLockEnabled
        /// Indicates whether this bucket has an Object Lock configuration enabled.
        /// Required: No
        /// Type: String
        /// Allowed Values: Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectLockEnabled")]
        public Union<string, IntrinsicFunction> ObjectLockEnabled { get; set; }

        /// <summary>
        /// Rule
        /// The Object Lock rule in place for the specified object.
        /// Required: No
        /// Type: ObjectLockRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rule")]
        public ObjectLockRule Rule { get; set; }

    }
}
