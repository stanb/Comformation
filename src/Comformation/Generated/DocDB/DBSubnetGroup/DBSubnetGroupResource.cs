using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DocDB.DBSubnetGroup
{
    /// <summary>
    /// AWS::DocDB::DBSubnetGroup
    /// The AWS::DocDB::DBSubnetGroup Amazon DocumentDB resource describes a DBSubnetGroup. For more information, see
    /// DBSubnetGroup in the Amazon DocumentDB Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbsubnetgroup.html
    /// </summary>
    public class DBSubnetGroupResource : ResourceBase
    {
        public class DBSubnetGroupProperties
        {
            /// <summary>
            /// DBSubnetGroupName
            /// The name of the DB subnet group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupName { get; set; }

            /// <summary>
            /// DBSubnetGroupDescription
            /// The description of the DB subnet group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DBSubnetGroupDescription { get; set; }

            /// <summary>
            /// SubnetIds
            /// List of subnet identifiers.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// A list of up to 50 tags. A tag is metadata assigned to an Amazon DocumentDB (with MongoDB
            /// compatibility) resource consisting of a key-value pair.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DocDB::DBSubnetGroup";

        public DBSubnetGroupProperties Properties { get; } = new DBSubnetGroupProperties();

    }
}
