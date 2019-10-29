using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.InputSecurityGroup
{
    /// <summary>
    /// AWS::MediaLive::InputSecurityGroup
    /// The AWS::MediaLive::InputSecurityGroup is a MediaLive resource type that creates an input security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-inputsecuritygroup.html
    /// </summary>
    public class InputSecurityGroupResource : ResourceBase
    {
        public class InputSecurityGroupProperties
        {
            /// <summary>
            /// WhitelistRules
            /// The list of IPv4 CIDR addresses to include in the input security group as &quot;allowed&quot; addresses.
            /// Required: No
            /// Type: List of InputWhitelistRuleCidr
            /// Update requires: No interruption
            /// </summary>
			public List<InputWhitelistRuleCidr> WhitelistRules { get; set; }

            /// <summary>
            /// Tags
            /// A collection of tags for this input security group. Each tag is a key-value pair.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::MediaLive::InputSecurityGroup";

        public InputSecurityGroupProperties Properties { get; } = new InputSecurityGroupProperties();

    }

	public static class InputSecurityGroupAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
