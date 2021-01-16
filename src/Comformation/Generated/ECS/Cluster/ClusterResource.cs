using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// Tags
            /// 		
            /// The metadata that you apply to the cluster to help you categorize and organize them. 			Each tag
            /// consists of a key and an optional value, both of which you define.
            /// 		
            /// The following basic restrictions apply to tags:
            /// Maximum number of tags per resource - 50 For each resource, each tag key must be unique, and each
            /// tag key can have only one value. Maximum key length - 128 Unicode characters in UTF-8 Maximum value
            /// length - 256 Unicode characters in UTF-8 If your tagging schema is used across multiple services and
            /// resources, remember that other services may have restrictions on allowed characters. Generally
            /// allowed characters are: letters, numbers, and spaces representable in UTF-8, and the following
            /// characters: + - = . _ : / @. Tag keys and values are case-sensitive. Do not use aws:, AWS:, or any
            /// upper or lowercase combination of such as a prefix for either keys or values as it is reserved for
            /// AWS use. You cannot edit or delete tag keys or values with this prefix. Tags with this prefix do not
            /// count against your tags per resource limit.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ClusterName
            /// A user-generated string that you use to identify your cluster. If you don&#39;t specify a name, AWS
            /// CloudFormation generates a unique physical ID for the name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// ClusterSettings
            /// The setting to use when creating a cluster. This parameter is used to enable CloudWatch Container
            /// Insights for a cluster. If this value is specified, it will override the containerInsights value set
            /// with PutAccountSetting or PutAccountSettingDefault.
            /// Required: No
            /// Type: List of ClusterSettings
            /// Update requires: No interruption
            /// </summary>
            public List<ClusterSettings> ClusterSettings { get; set; }

            /// <summary>
            /// CapacityProviders
            /// 		
            /// The capacity providers associated with the cluster.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> CapacityProviders { get; set; }

            /// <summary>
            /// DefaultCapacityProviderStrategy
            /// 		
            /// The default capacity provider strategy for the cluster. When services or tasks are run 			in the
            /// cluster with no launch type or capacity provider strategy specified, the default 			capacity
            /// provider strategy is used.
            /// 	
            /// Required: No
            /// Type: List of CapacityProviderStrategyItem
            /// Update requires: No interruption
            /// </summary>
            public List<CapacityProviderStrategyItem> DefaultCapacityProviderStrategy { get; set; }

        }

        public string Type { get; } = "AWS::ECS::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

    public static class ClusterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
