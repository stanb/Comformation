using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBClusterParameterGroup
{
    /// <summary>
    /// AWS::RDS::DBClusterParameterGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterparametergroup.html
    /// </summary>
    public class DBClusterParameterGroupResource : ResourceBase
    {
        public class DBClusterParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// A friendly description for this DB cluster parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Family
            /// The DB cluster parameter group family name. A DB cluster parameter group can be associated with one
            /// and only one DB cluster parameter group family, and can be applied only to a DB cluster running a DB
            /// engine and engine version compatible with that DB cluster parameter group family.
            /// Note The DB cluster parameter group family can&#39;t be changed when updating a DB cluster parameter
            /// group.
            /// To list all of the available parameter group families, use the following command:
            /// aws rds describe-db-engine-versions --query &quot;DBEngineVersions[]. DBParameterGroupFamily&quot;
            /// The output contains duplicates.
            /// For more information, see CreateDBClusterParameterGroup.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Parameters
            /// Provides a list of parameters for the DB cluster parameter group.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// Tags to assign to the DB cluster parameter group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBClusterParameterGroup";

        public DBClusterParameterGroupProperties Properties { get; } = new DBClusterParameterGroupProperties();

    }
}
