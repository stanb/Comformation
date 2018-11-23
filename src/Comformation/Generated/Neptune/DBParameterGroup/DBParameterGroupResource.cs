using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBParameterGroup
{
    /// <summary>
    /// AWS::Neptune::DBParameterGroup
    /// Creates a custom parameter group for DB instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbparametergroup.html
    /// </summary>
    public class DBParameterGroupResource : ResourceBase
    {
        public class DBParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// A friendly description of the DB parameter group. For example, &quot;My Parameter Group&quot;.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters to set for this DB parameter group.
            /// Required: No
            /// Type: A JSON object consisting of string key-value pairs, as shown in the following example:
            /// &quot;Parameters&quot; : { &quot;Key1&quot; : &quot;Value1&quot;, &quot;Key2&quot; : &quot;Value2&quot;, &quot;Key3&quot; : &quot;Value3&quot; }
            /// Update requires: No interruption or some interruption. Changes to dynamic parameters are applied
            /// immediately. During an update, if you have static parameters (whether they were changed or not), it
            /// triggers AWS CloudFormation to reboot the associated DB instance without failover.
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
            /// The tags that you want to attach to the DB parameter group.
            /// Required: No
            /// Type: A list of resource tags.
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// A friendly name for the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Neptune::DBParameterGroup";

        public DBParameterGroupProperties Properties { get; } = new DBParameterGroupProperties();

    }
}
