using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBClusterParameterGroup
{
    /// <summary>
    /// AWS::Neptune::DBClusterParameterGroup
    /// The AWS::Neptune::DBClusterParameterGroup resource creates a new Amazon Neptune DB cluster parameter group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbclusterparametergroup.html
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
            /// The parameters to set for this DB cluster parameter group.
            /// The parameters are expressed as a JSON object consisting of key-value pairs.
            /// If you update the parameters, some interruption may occur depending on which parameters you update.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Family
            /// Must be neptune1.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to this parameter group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// Provides the name of the DB cluster parameter group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Neptune::DBClusterParameterGroup";

        public DBClusterParameterGroupProperties Properties { get; } = new DBClusterParameterGroupProperties();

    }
}
