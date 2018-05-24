using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.ResourceGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-resourcegroup.html
    /// </summary>
    public class ResourceGroupResource : ResourceBase
    {
        public class ResourceGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-resourcegroup.html#cfn-inspector-resourcegroup-resourcegrouptags
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
