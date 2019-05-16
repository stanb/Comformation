using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RAM.ResourceShare
{
    /// <summary>
    /// AWS::RAM::ResourceShare
    /// Specifies a resource share.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html
    /// </summary>
    public class ResourceShareResource : ResourceBase
    {
        public class ResourceShareProperties
        {
            /// <summary>
            /// Principals
            /// The principals to associate with the resource share. The possible values are IDs of AWS accounts,
            /// the ARN of an OU or organization from AWS Organizations.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Principals { get; set; }

            /// <summary>
            /// AllowExternalPrincipals
            /// Indicates whether principals outside your AWS organization can be associated with a resource share.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowExternalPrincipals { get; set; }

            /// <summary>
            /// ResourceArns
            /// The Amazon Resource Names (ARN) of the resources to associate with the resource share.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ResourceArns { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the resource share.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RAM::ResourceShare";

        public ResourceShareProperties Properties { get; } = new ResourceShareProperties();

    }

	public static class ResourceShareAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
