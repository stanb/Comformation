using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.ResourceGroup
{
    /// <summary>
    /// AWS::Inspector::ResourceGroup
    /// The AWS::Inspector::ResourceGroup resource is used to create Amazon Inspector resource groups. A resource
    /// group defines a set of tags that, when queried, identify the AWS resources that make up the assessment target.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-resourcegroup.html
    /// </summary>
    public class ResourceGroupResource : ResourceBase
    {
        public class ResourceGroupProperties
        {
            /// <summary>
            /// ResourceGroupTags
            /// The tags (key and value pairs) of the resource group.
            /// Required: Yes
            /// Type: List of AWS CloudFormation Resource Tags
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-resourcegroup.html#cfn-inspector-resourcegroup-resourcegrouptags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> ResourceGroupTags { get; set; }

        }
    
        public string Type { get; } = "AWS::Inspector::ResourceGroup";
        
        public ResourceGroupProperties Properties { get; } = new ResourceGroupProperties();
    }

	public static class ResourceGroupAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
