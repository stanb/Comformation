using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBSubnetGroup
{
    /// <summary>
    /// AWS::Neptune::DBSubnetGroup
    /// The AWS::Neptune::DBSubnetGroup type creates an Amazon Neptune DB subnet group. Subnet groups must contain at
    /// least two subnets in two different Availability Zones in the same AWS Region.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbsubnetgroup.html
    /// </summary>
    public class DBSubnetGroupResource : ResourceBase
    {
        public class DBSubnetGroupProperties
        {
            /// <summary>
            /// DBSubnetGroupName
            /// The name for the DB subnet group. This value is stored as a lowercase string.
            /// Constraints: Must contain no more than 255 letters, numbers, periods, underscores, spaces, or
            /// hyphens. Must not be default.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DBSubnetGroupDescription
            /// The description for the DB subnet group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupDescription { get; set; }

            /// <summary>
            /// SubnetIds
            /// The Amazon EC2 subnet IDs for the DB subnet group.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the Amazon RDS database subnet group.
            /// Required: No
            /// Type: A list of resource tags in key-value format.
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Neptune::DBSubnetGroup";

        public DBSubnetGroupProperties Properties { get; } = new DBSubnetGroupProperties();

    }
}
