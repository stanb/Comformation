using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow S3DestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html
    /// </summary>
    public class S3DestinationProperties
    {

        /// <summary>
        /// BucketName
        /// The Amazon S3 bucket name in which Amazon AppFlow places the transferred data.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketPrefix
        /// The object key for the destination bucket in which Amazon AppFlow places the files.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

        /// <summary>
        /// S3OutputFormatConfig
        /// The configuration that determines how Amazon AppFlow should format the flow output data when Amazon
        /// S3 is used as the destination.
        /// Required: No
        /// Type: S3OutputFormatConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3OutputFormatConfig")]
        public S3OutputFormatConfig S3OutputFormatConfig { get; set; }

    }
}
