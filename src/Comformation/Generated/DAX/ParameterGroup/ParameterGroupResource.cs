using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.ParameterGroup
{
    /// <summary>
    /// AWS::DAX::ParameterGroup
    /// Use the AWS CloudFormation AWS::DAX::ParameterGroup resource to create a parameter group for use with Amazon
    /// DynamoDB.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html
    /// </summary>
    public class ParameterGroupResource : ResourceBase
    {
        public class ParameterGroupProperties
        {
            /// <summary>
            /// ParameterNameValues
            /// A map of DAX parameter names and values.
            /// Required: No
            /// Type: String to String map
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ParameterNameValues { get; set; }

            /// <summary>
            /// Description
            /// A description of the parameter group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption;
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ParameterGroupName
            /// The name of the parameter group.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> ParameterGroupName { get; set; }

        }
    
        public string Type { get; } = "AWS::DAX::ParameterGroup";
        
        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();

    }
}
