using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StreamingImage
{
    /// <summary>
    /// AWS::NimbleStudio::StreamingImage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-streamingimage.html
    /// </summary>
    public class StreamingImageResource : ResourceBase
    {
        public class StreamingImageProperties
        {
            /// <summary>
            /// StudioId
            /// The unique identifier for a studio resource. In Nimble Studio, all other resources are contained in
            /// a studio resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StudioId { get; set; }

            /// <summary>
            /// Ec2ImageId
            /// The ID of an EC2 machine image with which to create the streaming image.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Ec2ImageId { get; set; }

            /// <summary>
            /// Name
            /// A friendly name for a streaming image resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// A human-readable description of the streaming image.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::NimbleStudio::StreamingImage";

        public StreamingImageProperties Properties { get; } = new StreamingImageProperties();

    }

    public static class StreamingImageAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StreamingImageId = new ResourceAttribute<Union<string, IntrinsicFunction>>("StreamingImageId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Owner = new ResourceAttribute<Union<string, IntrinsicFunction>>("Owner");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> EulaIds = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("EulaIds");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Platform = new ResourceAttribute<Union<string, IntrinsicFunction>>("Platform");
    }
}
