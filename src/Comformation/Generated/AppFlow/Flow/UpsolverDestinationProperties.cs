using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow UpsolverDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html
    /// </summary>
    public class UpsolverDestinationProperties
    {

        /// <summary>
        /// BucketName
        /// The Upsolver Amazon S3 bucket name in which Amazon AppFlow places the transferred data.
        /// Required: Yes
        /// Type: String
        /// Minimum: 16
        /// Maximum: 63
        /// Pattern: ^(upsolver-appflow)\S*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketPrefix
        /// The object key for the destination Upsolver Amazon S3 bucket in which Amazon AppFlow places the
        /// files.
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
        /// The configuration that determines how data is formatted when Upsolver is used as the flow
        /// destination.
        /// Required: Yes
        /// Type: UpsolverS3OutputFormatConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3OutputFormatConfig")]
        public UpsolverS3OutputFormatConfig S3OutputFormatConfig { get; set; }

    }
}
