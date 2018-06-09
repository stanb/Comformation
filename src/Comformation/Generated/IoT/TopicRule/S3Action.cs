using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule S3Action
    /// S3 is a property of the Actions property that describes an action that writes data to an S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-s3action.html
    /// </summary>
    public class S3Action
    {

        /// <summary>
        /// BucketName
        /// The name of the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// Key
        /// The object key (the name of an object in the S3 bucket).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to Amazon S3.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
