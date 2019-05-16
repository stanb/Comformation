using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBClusterParameterGroup
{
    /// <summary>
    /// AWS::RDS::DBClusterParameterGroup
    /// The AWS::RDS::DBClusterParameterGroup resource creates a new Amazon RDS DB cluster parameter group. For more
    /// information, see Managing an Amazon Aurora DB Cluster in the Amazon Aurora User Guide.
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
            /// Provides the name of the DB parameter group family that this DB cluster parameter group is
            /// compatible with.
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
