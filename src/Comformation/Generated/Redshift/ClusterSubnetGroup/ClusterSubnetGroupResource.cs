using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterSubnetGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterSubnetGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersubnetgroup.html
    /// </summary>
    public class ClusterSubnetGroupResource : ResourceBase
    {
        public class ClusterSubnetGroupProperties
        {
            /// <summary>
            /// Description
            /// A description for the subnet group.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SubnetIds
            /// An array of VPC subnet IDs. A maximum of 20 subnets can be modified in a single request.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this subnet group. Use tags
            /// to manage your resources.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Redshift::ClusterSubnetGroup";

        public ClusterSubnetGroupProperties Properties { get; } = new ClusterSubnetGroupProperties();

    }
}
