using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ObjectLockConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-objectlockconfiguration.html
    /// </summary>
    public class ObjectLockConfiguration
    {

        /// <summary>
        /// ObjectLockEnabled
        /// Indicates whether this bucket has an Object Lock configuration enabled. Enable ObjectLockEnabled
        /// when you apply ObjectLockConfiguration to a bucket.
        /// Required: No
        /// Type: String
        /// Allowed values: Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectLockEnabled")]
        public Union<string, IntrinsicFunction> ObjectLockEnabled { get; set; }

        /// <summary>
        /// Rule
        /// Specifies the Object Lock rule for the specified object. Enable the this rule when you apply
        /// ObjectLockConfiguration to a bucket. If Object Lock is turned on, bucket settings require both Mode
        /// and a period of either Days or Years. You cannot specify Days and Years at the same time. For more
        /// information, see ObjectLockRule and DefaultRetention.
        /// Required: Conditional
        /// Type: ObjectLockRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rule")]
        public ObjectLockRule Rule { get; set; }

    }
}
