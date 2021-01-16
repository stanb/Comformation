using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ResourceGroups.Group
{
    /// <summary>
    /// AWS::ResourceGroups::Group
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourcegroups-group.html
    /// </summary>
    public class GroupResource : ResourceBase
    {
        public class GroupProperties
        {
            /// <summary>
            /// Name
            /// The name of a resource group. Specify a name that is unique in the Region. To create multiple
            /// resource groups based on the same CloudFormation stack, use unique names for each.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the resource group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ResourceQuery
            /// The resource query that determines which AWS resources are members of the associated resource group.
            /// Required: No
            /// Type: ResourceQuery
            /// Update requires: No interruption
            /// </summary>
            public ResourceQuery ResourceQuery { get; set; }

            /// <summary>
            /// Tags
            /// The tags associated with the specified resource group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ResourceGroups::Group";

        public GroupProperties Properties { get; } = new GroupProperties();

    }

    public static class GroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
