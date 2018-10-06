using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBParameterGroup
{
    /// <summary>
    /// AWS::RDS::DBParameterGroup
    /// Creates a custom parameter group for an RDS database family. For more information about RDS parameter groups,
    /// see Working with DB Parameter Groups in the Amazon Relational Database Service User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html
    /// </summary>
    public class DBParameterGroupResource : ResourceBase
    {
        public class DBParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// A friendly description of the RDS parameter group. For example, &quot;My Parameter Group&quot;.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Family
            /// The database family of this RDS parameter group. For example, &quot;MySQL5. 1&quot;.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters to set for this RDS parameter group.
            /// Required: No
            /// Type: A JSON object consisting of string key-value pairs, as shown in the following example:
            /// &quot;Parameters&quot; : { &quot;Key1&quot; : &quot;Value1&quot;, &quot;Key2&quot; : &quot;Value2&quot;, &quot;Key3&quot; : &quot;Value3&quot; }
            /// Update requires: No interruption or Some interruptions. Changes to dynamic parameters are applied
            /// immediately. During an update, if you have static parameters (whether they were changed or not),
            /// triggers AWS CloudFormation to reboot the associated DB instance without failover.
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the RDS parameter group.
            /// Required: No
            /// Type: A list of resource tags.
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::DBParameterGroup";
        
        public DBParameterGroupProperties Properties { get; } = new DBParameterGroupProperties();

    }
}
