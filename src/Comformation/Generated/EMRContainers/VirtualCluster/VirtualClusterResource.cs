using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMRContainers.VirtualCluster
{
    /// <summary>
    /// AWS::EMRContainers::VirtualCluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-virtualcluster.html
    /// </summary>
    public class VirtualClusterResource : ResourceBase
    {
        public class VirtualClusterProperties
        {
            /// <summary>
            /// ContainerProvider
            /// The container provider of the virtual cluster.
            /// Required: Yes
            /// Type: ContainerProvider
            /// Update requires: Replacement
            /// </summary>
            public ContainerProvider ContainerProvider { get; set; }

            /// <summary>
            /// Name
            /// The name of the virtual cluster.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\. \-_/#A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EMRContainers::VirtualCluster";

        public VirtualClusterProperties Properties { get; } = new VirtualClusterProperties();

    }

    public static class VirtualClusterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
