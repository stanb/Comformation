using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBClusterParameterGroup
{
    /// <summary>
    /// AWS::RDS::DBClusterParameterGroup
    /// The AWS::RDS::DBClusterParameterGroup resource creates a new Amazon Relational Database Service (Amazon RDS)
    /// database (DB) cluster parameter group. For more information about DB cluster parameter groups, see Appendix:
    /// DB Cluster and DB Instance Parameters in the Amazon RDS User Guide.
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
            /// The database family of this DB cluster parameter group, such as aurora5. 6.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters to set for this DB cluster parameter group. For a list of parameter keys, see
            /// Appendix: DB Cluster and DB Instance Parameters in the Amazon RDS User Guide.
            /// Changes to dynamic parameters are applied immediately. Changes to static parameters require a reboot
            /// without failover to the DB instance that is associated with the parameter group before the change
            /// can take effect.
            /// Required: Yes
            /// Type: A JSON object consisting of string key-value pairs, as shown in the following example:
            /// &quot;Parameters&quot; : { &quot;Key1&quot; : &quot;Value1&quot;, &quot;Key2&quot; : &quot;Value2&quot;, &quot;Key3&quot; : &quot;Value3&quot; }
            /// Update requires: No interruption or some interruptions, depending on the parameters that you update.
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to this parameter group.
            /// Required: No
            /// Type: A list of resource tags
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBClusterParameterGroup";

        public DBClusterParameterGroupProperties Properties { get; } = new DBClusterParameterGroupProperties();

    }
}
