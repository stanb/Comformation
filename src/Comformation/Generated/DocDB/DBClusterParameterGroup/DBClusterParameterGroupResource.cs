using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DocDB.DBClusterParameterGroup
{
    /// <summary>
    /// AWS::DocDB::DBClusterParameterGroup
    /// The AWS::DocDB::DBClusterParameterGroup Amazon DocumentDB (with MongoDB compatibility) resource describes a
    /// DBClusterParameterGroup. For more information, see DBClusterParameterGroup in the Amazon DocumentDB Developer
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-dbclusterparametergroup.html
    /// </summary>
    public class DBClusterParameterGroupResource : ResourceBase
    {
        public class DBClusterParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// Provides the customer-specified description for this DB cluster parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Parameters
            /// Provides the name of the DB cluster parameter group.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Family
            /// The DB cluster parameter group from which user created DB cluster parameter groups are created. For
            /// example, default. docdb3. 6.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Tags
            /// A list of up to 50 tags. A tag is metadata assigned to an Amazon DocumentDB resource consisting of a
            /// key-value pair.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// Provides the name of the DB parameter group family that this DB cluster parameter group is
            /// compatible with.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::DocDB::DBClusterParameterGroup";

        public DBClusterParameterGroupProperties Properties { get; } = new DBClusterParameterGroupProperties();

    }
}
