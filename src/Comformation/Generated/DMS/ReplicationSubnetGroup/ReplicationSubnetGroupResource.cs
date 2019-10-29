using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.ReplicationSubnetGroup
{
    /// <summary>
    /// AWS::DMS::ReplicationSubnetGroup
    /// The AWS::DMS::ReplicationSubnetGroup resource creates an AWS DMS replication subnet group. Subnet groups must
    /// contain at least two subnets in two different Availability Zones in the same region.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationsubnetgroup.html
    /// </summary>
    public class ReplicationSubnetGroupResource : ResourceBase
    {
        public class ReplicationSubnetGroupProperties
        {
            /// <summary>
            /// ReplicationSubnetGroupDescription
            /// The description for the subnet group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationSubnetGroupDescription { get; set; }

            /// <summary>
            /// ReplicationSubnetGroupIdentifier
            /// The identifier for the replication subnet group. If you don&#39;t specify a name, AWS CloudFormation
            /// generates a unique ID and uses that ID for the identifier.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ReplicationSubnetGroupIdentifier { get; set; }

            /// <summary>
            /// SubnetIds
            /// One or more subnet IDs to be assigned to the subnet group.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags to be assigned to the subnet group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DMS::ReplicationSubnetGroup";

        public ReplicationSubnetGroupProperties Properties { get; } = new ReplicationSubnetGroupProperties();

    }
}
