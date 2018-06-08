using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Parameter
{
    /// <summary>
    /// AWS::SSM::Parameter
    /// The AWS::SSM::Parameter resource creates an SSM parameter in AWS Systems Manager Parameter Store.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-parameter.html
    /// </summary>
    public class ParameterResource : ResourceBase
    {
        public class ParameterProperties
        {
            /// <summary>
            /// Type
            /// The type of parameter. Valid values include the following: String or StringList.
            /// Note AWS CloudFormation doesn't support the SecureString parameter type.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// Information about the parameter that you want to add to the system.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AllowedPattern
            /// A regular expression used to validate the parameter value. For example, for String types with values
            /// restricted to numbers, you can specify the following: AllowedPattern=^\d+$
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AllowedPattern { get; set; }

            /// <summary>
            /// Value
            /// The parameter value. Value must not nest another parameter. Do not use {{}} in the value.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Value { get; set; }

            /// <summary>
            /// Name
            /// The name of the parameter. Names must not be prefixed with aws or ssm.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::SSM::Parameter";
        
        public ParameterProperties Properties { get; } = new ParameterProperties();
    }

	public static class ParameterAttributes
	{
        public static readonly ResourceAttribute<string> Type = new ResourceAttribute<string>("Type");
        public static readonly ResourceAttribute<string> Value = new ResourceAttribute<string>("Value");
	}
}
