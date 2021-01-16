using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IVS.StreamKey
{
    /// <summary>
    /// AWS::IVS::StreamKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-streamkey.html
    /// </summary>
    public class StreamKeyResource : ResourceBase
    {
        public class StreamKeyProperties
        {
            /// <summary>
            /// ChannelArn
            /// Channel ARN for the stream.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^arn:aws:[is]vs:[a-z0-9-]+:[0-9]+:channel/[a-zA-Z0-9-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ChannelArn { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IVS::StreamKey";

        public StreamKeyProperties Properties { get; } = new StreamKeyProperties();

    }

    public static class StreamKeyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Value = new ResourceAttribute<Union<string, IntrinsicFunction>>("Value");
    }
}
