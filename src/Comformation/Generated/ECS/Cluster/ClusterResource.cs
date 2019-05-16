using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster
    /// The AWS::ECS::Cluster resource creates an Amazon Elastic Container Service (Amazon ECS) cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// ClusterName
            /// A user-generated string that you use to identify your cluster. If you don&#39;t specify a name, AWS
            /// CloudFormation generates a unique physical ID for the name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

        }

        public string Type { get; } = "AWS::ECS::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
