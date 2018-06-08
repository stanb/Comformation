using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster
    /// The AWS::ECS::Cluster resource creates an Amazon Elastic Container Service (Amazon ECS) cluster. This resource
    /// has no properties; use the Amazon ECS container agent to connect to the cluster. For more information, see
    /// Amazon ECS Container Agent in the Amazon Elastic Container Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// ClusterName
            /// A name for the cluster. If you don't specify a name, AWS CloudFormation generates a unique physical
            /// ID for the name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
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
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
