using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBSubnetGroup
{
    /// <summary>
    /// AWS::Neptune::DBSubnetGroup
    /// The AWS::Neptune::DBSubnetGroup type creates a Neptune DB subnet group. Subnet groups must contain at least
    /// two subnets in two different Availability Zones in the same region.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbsubnetgroup.html
    /// </summary>
    public class DBSubnetGroupResource : ResourceBase
    {
        public class DBSubnetGroupProperties
        {
            /// <summary>
            /// DBSubnetGroupName
            /// The name for the DB Subnet Group. This value is stored as a lowercase string.
            /// Constraints: Must contain no more than 255 letters, numbers, periods, underscores, spaces, or
            /// hyphens. Must not be default.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DBSubnetGroupDescription
            /// The description for the DB Subnet Group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupDescription { get; set; }

            /// <summary>
            /// SubnetIds
            /// The EC2 Subnet IDs for the DB Subnet Group.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the RDS database subnet group.
            /// Required: No
            /// Type: A list of resource tags in key-value format.
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::Neptune::DBSubnetGroup";
        
        public DBSubnetGroupProperties Properties { get; } = new DBSubnetGroupProperties();
    }
}
