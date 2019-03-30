using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RAM.ResourceShare
{
    /// <summary>
    /// AWS::RAM::ResourceShare
    /// The AWS::RAM::ResourceShare resource is used to create, update, and delete an Amazon ResourceShare. For more
    /// information, see ResourceShare in the AWS RAM API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html
    /// </summary>
    public class ResourceShareResource : ResourceBase
    {
        public class ResourceShareProperties
        {
            /// <summary>
            /// Principals
            /// A list of account IDs, organizational unit ARNs, and organization ARN to put into the ResourceShare.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Principals { get; set; }

            /// <summary>
            /// AllowExternalPrincipals
            /// Indicates whether principals outside of your organization are allowed in this ResourceShare.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowExternalPrincipals { get; set; }

            /// <summary>
            /// ResourceArns
            /// The resource ARNs to put into the ResourceShare.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ResourceArns { get; set; }

            /// <summary>
            /// Tags
            /// The tags on this ResourceShare.
            /// Required: No
            /// Type: List of Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// A descriptive name for the ResourceShare.
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
