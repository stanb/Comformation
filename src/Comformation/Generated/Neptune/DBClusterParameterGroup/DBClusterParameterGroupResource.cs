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
            /// A friendly description for this DB cluster parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters to set for this DB cluster parameter group.
            /// Changes to dynamic parameters are applied immediately. Changes to static parameters require a reboot
            /// without failover to the DB instance that is associated with the parameter group before the change
            /// can take effect.
            /// Required: Yes
            /// Type: A JSON object consisting of string key-value pairs, as shown in the following example:
            /// "Parameters" : { "Key1" : "Value1", "Key2" : "Value2", "Key3" : "Value3" }
            /// Update requires: No interruption or some interruptions, depending on the parameters that you update.
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
            /// Type: A list of resource tags
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// A friendly name for the cluster.
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
