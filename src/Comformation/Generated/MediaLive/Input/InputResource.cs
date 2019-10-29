using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Input
{
    /// <summary>
    /// AWS::MediaLive::Input
    /// The AWS::MediaLive::Input resource is a MediaLive resource type that creates an input.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html
    /// </summary>
    public class InputResource : ResourceBase
    {
        public class InputProperties
        {
            /// <summary>
            /// Type
            /// The type for this input.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Destinations
            /// The destination settings for push types of inputs. If the input is a pull type, these settings don&#39;t
            /// apply.
            /// Required: No
            /// Type: List of InputDestinationRequest
            /// Update requires: No interruption
            /// </summary>
			public List<InputDestinationRequest> Destinations { get; set; }

            /// <summary>
            /// Vpc
            /// Settings that apply only if the input is an Amazon VPC input.
            /// Required: No
            /// Type: InputVpcRequest
            /// Update requires: Replacement
            /// </summary>
			public InputVpcRequest Vpc { get; set; }

            /// <summary>
            /// MediaConnectFlows
            /// Settings that apply only if the input is a MediaConnect input.
            /// Required: No
            /// Type: List of MediaConnectFlowRequest
            /// Update requires: No interruption
            /// </summary>
			public List<MediaConnectFlowRequest> MediaConnectFlows { get; set; }

            /// <summary>
            /// InputSecurityGroups
            /// The list of input security groups (referenced by IDs) to attach to the input if the input is a push
            /// type.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> InputSecurityGroups { get; set; }

            /// <summary>
            /// Sources
            /// The source settings for a pull type of input. These settings don&#39;t apply if the input is a push
            /// type.
            /// Required: No
            /// Type: List of InputSourceRequest
            /// Update requires: No interruption
            /// </summary>
			public List<InputSourceRequest> Sources { get; set; }

            /// <summary>
            /// RoleArn
            /// The IAM role for MediaLive to assume when creating a MediaConnect input or Amazon VPC input. This
            /// doesn&#39;t apply to other types of inputs. The role is identified by its ARN.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// A collection of tags for this input. Each tag is a key-value pair.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// A name for the input.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::MediaLive::Input";

        public InputProperties Properties { get; } = new InputProperties();

    }

	public static class InputAttributes
	{
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> Destinations = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("Destinations");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> Sources = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("Sources");
	}
}
