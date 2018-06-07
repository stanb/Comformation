using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBParameterGroup
{
    /// <summary>
    /// AWS::RDS::DBParameterGroup
    /// Creates a custom parameter group for an RDS database family. For more information about RDS parameter groups,
    /// see Working with DB Parameter Groups in the Amazon Relational Database Service User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html
    /// </summary>
    public class DBParameterGroupResource : ResourceBase
    {
        public class DBParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// A friendly description of the RDS parameter group. For example, "My Parameter Group".
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html#cfn-rds-dbparametergroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Family
            /// The database family of this RDS parameter group. For example, "MySQL5. 1".
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html#cfn-rds-dbparametergroup-family
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters to set for this RDS parameter group.
            /// Required: No
            /// Type: A JSON object consisting of string key-value pairs, as shown in the following example:
            /// "Parameters" : { "Key1" : "Value1", "Key2" : "Value2", "Key3" : "Value3" }
            /// Update requires: No interruption or Some interruptions. Changes to dynamic parameters are applied
            /// immediately. During an update, if you have static parameters (whether they were changed or not),
            /// triggers AWS CloudFormation to reboot the associated DB instance without failover.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html#cfn-rds-dbparametergroup-parameters
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// The tags that you want to attach to the RDS parameter group.
            /// Required: No
            /// Type: A list of resource tags.
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbparametergroup.html#cfn-rds-dbparametergroup-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::DBParameterGroup";
        
        public DBParameterGroupProperties Properties { get; } = new DBParameterGroupProperties();
    }
}
