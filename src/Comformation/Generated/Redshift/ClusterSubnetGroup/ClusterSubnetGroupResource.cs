using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterSubnetGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterSubnetGroup
    /// Creates an Amazon Redshift subnet group. You must provide a list of one or more subnets in your existing
    /// Amazon VPC when creating an Amazon Redshift subnet group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersubnetgroup.html
    /// </summary>
    public class ClusterSubnetGroupResource : ResourceBase
    {
        public class ClusterSubnetGroupProperties
        {
            /// <summary>
            /// Description
            /// A description of the subnet group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SubnetIds
            /// A list of VPC subnet IDs. You can modify a maximum of 20 subnets.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this subnet group. Use tags
            /// to manage your resources.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Redshift::ClusterSubnetGroup";

        public ClusterSubnetGroupProperties Properties { get; } = new ClusterSubnetGroupProperties();

    }
}
