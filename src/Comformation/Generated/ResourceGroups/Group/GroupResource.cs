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
            /// The name of a resource group. The name must be unique within the AWS Region in which you create the
            /// resource. To create multiple resource groups based on the same CloudFormation stack, you must
            /// generate unique names for each.
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
            /// The resource query structure that is used to dynamically determine which AWS resources are members
            /// of the associated resource group. For more information about queries and how to construct them, see
            /// Build queries and groups in AWS Resource Groups in the AWS Resource Groups User Guide
            /// Note You can include either a ResourceQuery or a Configuration, but not both. You can specify the
            /// group&#39;s membership either by using a ResourceQuery or by using a list of Resources, but not both.
            /// Required: Conditional
            /// Type: ResourceQuery
            /// Update requires: No interruption
            /// </summary>
            public ResourceQuery ResourceQuery { get; set; }

            /// <summary>
            /// Tags
            /// The tag key and value pairs that are attached to the resource group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Configuration
            /// The service configuration currently associated with the resource group and in effect for the members
            /// of the resource group. A Configuration consists of one or more ConfigurationItem entries. For
            /// information about service configurations for resource groups and how to construct them, see Service
            /// configurations for resource groups in the AWS Resource Groups User Guide.
            /// Note You can include either a Configuration or a ResourceQuery, but not both.
            /// Required: Conditional
            /// Type: List of ConfigurationItem
            /// Update requires: No interruption
            /// </summary>
            public List<ConfigurationItem> Configuration { get; set; }

            /// <summary>
            /// Resources
            /// A list of the Amazon Resource Names (ARNs) of AWS resources that you want to add to the specified
            /// group.
            /// Note You can specify the group membership either by using a list of Resources or by using a
            /// ResourceQuery, but not both. You can include a Resources property only if you also specify a
            /// Configuration property.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Resources { get; set; }

        }

        public string Type { get; } = "AWS::ResourceGroups::Group";

        public GroupProperties Properties { get; } = new GroupProperties();

    }

    public static class GroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
