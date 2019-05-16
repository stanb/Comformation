using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.ResourceGroup
{
    /// <summary>
    /// AWS::Inspector::ResourceGroup
    /// The AWS::Inspector::ResourceGroup resource is used to create Amazon Inspector resource groups. A resource
    /// group defines a set of tags that, when queried, identify the AWS resources that make up the assessment target.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-resourcegroup.html
    /// </summary>
    public class ResourceGroupResource : ResourceBase
    {
        public class ResourceGroupProperties
        {
            /// <summary>
            /// ResourceGroupTags
            /// The tags (key and value pairs) that will be associated with the resource group.
            /// For more information, see Tag.
            /// Required: Yes
            /// Type: List of Tag
            /// Maximum: 10
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> ResourceGroupTags { get; set; }

        }

        public string Type { get; } = "AWS::Inspector::ResourceGroup";

        public ResourceGroupProperties Properties { get; } = new ResourceGroupProperties();

    }

	public static class ResourceGroupAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
