using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule S3Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-s3action.html
    /// </summary>
    public class S3Action
    {

        /// <summary>
        /// BucketName
        /// The Amazon S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// Key
        /// The object key. For more information, see Actions, resources, and condition keys for Amazon S3.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// CannedAcl
        /// The Amazon S3 canned ACL that controls access to the object identified by the object key. For more
        /// information, see S3 canned ACLs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CannedAcl")]
        public Union<string, IntrinsicFunction> CannedAcl { get; set; }

    }
}
