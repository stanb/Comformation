using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinition
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinition
    /// The AWS::Greengrass::FunctionDefinition resource represents a function definition for AWS IoT Greengrass.
    /// Function definitions are used to organize your function definition versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinition.html
    /// </summary>
    public class FunctionDefinitionResource : ResourceBase
    {
        public class FunctionDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The function definition version to include when the function definition is created. A function
            /// definition version contains a list of function property types.
            /// 				
            /// Note To associate a function definition version after the function definition is created, 				
            /// create an AWS::Greengrass::FunctionDefinitionVersion 				 resource and specify the ID of this
            /// function definition.
            /// Required: No
            /// Type: FunctionDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
			public FunctionDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Tags
            /// Application-specific metadata to attach to the function definition. 		 You can use tags in IAM
            /// policies to control access to AWS IoT Greengrass resources. 		 You can also use tags to categorize
            /// your resources. For more information, see 		 Tagging Your AWS IoT Greengrass 		 Resources in the AWS
            /// IoT Greengrass Developer Guide.
            /// 		
            /// This Json property type is processed as a map of key-value pairs. It uses the following format,
            /// which 		 is different from most Tags implementations in AWS CloudFormation templates.
            /// &quot;Tags&quot;: { &quot;KeyName0&quot;: &quot;value&quot;, &quot;KeyName1&quot;: &quot;value&quot;, &quot;KeyName2&quot;: &quot;value&quot; }
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the function definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::FunctionDefinition";

        public FunctionDefinitionProperties Properties { get; } = new FunctionDefinitionProperties();

    }

	public static class FunctionDefinitionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
