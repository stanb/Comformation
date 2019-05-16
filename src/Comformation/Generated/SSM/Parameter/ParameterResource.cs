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
            /// Note AWS CloudFormation doesn&#39;t support the SecureString parameter type.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: SecureString | String | StringList
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// Information about the parameter.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AllowedPattern
            /// A regular expression used to validate the parameter value. For example, for String types with values
            /// restricted to numbers, you can specify the following: AllowedPattern=^\d+$
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AllowedPattern { get; set; }

            /// <summary>
            /// Value
            /// The parameter value.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Value { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the parameter.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::SSM::Parameter";

        public ParameterProperties Properties { get; } = new ParameterProperties();

    }

	public static class ParameterAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Type = new ResourceAttribute<Union<string, IntrinsicFunction>>("Type");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Value = new ResourceAttribute<Union<string, IntrinsicFunction>>("Value");
	}
}
