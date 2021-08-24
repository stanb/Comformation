using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.Cluster
{
    /// <summary>
    /// AWS::Route53RecoveryControl::Cluster
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// Name
            /// Name of the cluster. You can use any non-white space character in the name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryControl::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

    public static class ClusterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClusterArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClusterArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<List<ClusterEndpoint>> ClusterEndpoints = new ResourceAttribute<List<ClusterEndpoint>>("ClusterEndpoints");
    }
}
