using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html
    /// </summary>
    public class ChannelResource : ResourceBase
    {
        public class ChannelProperties
        {
            /// <summary>
            /// InputAttachments
            /// The list of input attachments for the channel.
            /// Required: No
            /// Type: List of InputAttachment
            /// Update requires: No interruption
            /// </summary>
            public List<InputAttachment> InputAttachments { get; set; }

            /// <summary>
            /// InputSpecification
            /// The input specification for this channel. It specifies the key characteristics of the inputs for
            /// this channel: the maximum bitrate, the resolution, and the codec.
            /// Required: No
            /// Type: InputSpecification
            /// Update requires: No interruption
            /// </summary>
            public InputSpecification InputSpecification { get; set; }

            /// <summary>
            /// ChannelClass
            /// The class for this channel. For a channel with two pipelines, the class is STANDARD. For a channel
            /// with one pipeline, the class is SINGLE_PIPELINE.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ChannelClass { get; set; }

            /// <summary>
            /// EncoderSettings
            /// The encoding configuration for the output content.
            /// Required: No
            /// Type: EncoderSettings
            /// Update requires: No interruption
            /// </summary>
            public EncoderSettings EncoderSettings { get; set; }

            /// <summary>
            /// Destinations
            /// The settings that identify the destination for the outputs in this MediaLive output package.
            /// Required: No
            /// Type: List of OutputDestination
            /// Update requires: No interruption
            /// </summary>
            public List<OutputDestination> Destinations { get; set; }

            /// <summary>
            /// Vpc
            /// Settings to enable VPC mode in the channel, so that the endpoints for all outputs are in your VPC.
            /// Required: No
            /// Type: VpcOutputSettings
            /// Update requires: Replacement
            /// </summary>
            public VpcOutputSettings Vpc { get; set; }

            /// <summary>
            /// CdiInputSpecification
            /// Specification of CDI inputs for this channel.
            /// Required: No
            /// Type: CdiInputSpecification
            /// Update requires: No interruption
            /// </summary>
            public CdiInputSpecification CdiInputSpecification { get; set; }

            /// <summary>
            /// LogLevel
            /// The verbosity for logging activity for this channel. Charges for logging (which are generated
            /// through Amazon CloudWatch Logging) are higher for higher verbosities.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LogLevel { get; set; }

            /// <summary>
            /// RoleArn
            /// The IAM role for MediaLive to assume when running this channel. The role is identified by its ARN.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// A collection of tags for this channel. Each tag is a key-value pair.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// A name for this audio selector. The AudioDescription (in an output) references this name in order to
            /// identify a specific input audio to include in that output.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::MediaLive::Channel";

        public ChannelProperties Properties { get; } = new ChannelProperties();

    }

    public static class ChannelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> Inputs = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("Inputs");
    }
}
