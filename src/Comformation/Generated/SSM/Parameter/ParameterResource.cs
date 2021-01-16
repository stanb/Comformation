using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Parameter
{
    /// <summary>
    /// AWS::SSM::Parameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-parameter.html
    /// </summary>
    public class ParameterResource : ResourceBase
    {
        public class ParameterProperties
        {
            /// <summary>
            /// Type
            /// The type of parameter.
            /// Note AWS CloudFormation doesn&#39;t support creating a SecureString parameter type.
            /// Allowed Values: String | StringList
            /// Required: Yes
            /// Type: String
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
            /// Policies
            /// Information about the policies assigned to a parameter.
            /// Assigning parameter policies in the AWS Systems Manager User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Policies { get; set; }

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
            /// Tier
            /// The parameter tier.
            /// Required: No
            /// Type: String
            /// Allowed values: Advanced | Intelligent-Tiering | Standard
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Tier { get; set; }

            /// <summary>
            /// Value
            /// The parameter value.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Value { get; set; }

            /// <summary>
            /// DataType
            /// The data type of the parameter, such as text or aws:ec2:image. The default is text.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DataType { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you assign to a resource in the form of an arbitrary set of tags (key-value
            /// pairs). Tags enable you to categorize a resource in different ways, such as by purpose, owner, or
            /// environment. For example, you might want to tag a Systems Manager parameter to identify the type of
            /// resource to which it applies, the environment, or the type of configuration data referenced by the
            /// parameter.
            /// Required: No
            /// Type: Json
            /// Maximum: 1000
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
