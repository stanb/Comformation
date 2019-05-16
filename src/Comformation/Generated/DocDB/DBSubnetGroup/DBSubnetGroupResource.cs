using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DocDB.DBSubnetGroup
{
    /// <summary>
    /// AWS::DocDB::DBSubnetGroup
    /// The AWS::DocDB::DBSubnetGroup Amazon DocumentDB (with MongoDB compatibility) resource describes a
    /// DBSubnetGroup. DB subnet groups must contain at least one subnet in at least two Availability Zones in the AWS
    /// Region. For more information, see DBSubnetGroup in the Amazon DocumentDB Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbsubnetgroup.html
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
            /// Example: mySubnetgroup
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
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// The tags to be assigned to the DB subnet group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DocDB::DBSubnetGroup";

        public DBSubnetGroupProperties Properties { get; } = new DBSubnetGroupProperties();

    }
}
