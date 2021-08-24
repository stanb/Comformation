using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.ClusterCapacityProviderAssociations
{
    /// <summary>
    /// AWS::ECS::ClusterCapacityProviderAssociations
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-clustercapacityproviderassociations.html
    /// </summary>
    public class ClusterCapacityProviderAssociationsResource : ResourceBase
    {
        public class ClusterCapacityProviderAssociationsProperties
        {
            /// <summary>
            /// CapacityProviders
            /// The capacity providers to associate with the cluster.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> CapacityProviders { get; set; }

            /// <summary>
            /// Cluster
            /// The cluster the capacity provider association is the target of.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Cluster { get; set; }

            /// <summary>
            /// DefaultCapacityProviderStrategy
            /// The default capacity provider strategy to associate with the cluster.
            /// Required: Yes
            /// Type: List of CapacityProviderStrategy
            /// Update requires: No interruption
            /// </summary>
            public List<CapacityProviderStrategy> DefaultCapacityProviderStrategy { get; set; }

        }

        public string Type { get; } = "AWS::ECS::ClusterCapacityProviderAssociations";

        public ClusterCapacityProviderAssociationsProperties Properties { get; } = new ClusterCapacityProviderAssociationsProperties();

    }
}
