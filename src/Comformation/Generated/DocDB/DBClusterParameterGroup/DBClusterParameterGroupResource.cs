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
            /// The description for the cluster parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Parameters
            /// Provides a list of parameters for the cluster parameter group.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Family
            /// The cluster parameter group family name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Tags
            /// The tags to be assigned to the cluster parameter group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the cluster parameter group.
            /// Constraints:
            /// Must match the name of an existing DBClusterParameterGroup.
            /// Note This value is stored as a lowercase string.
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
