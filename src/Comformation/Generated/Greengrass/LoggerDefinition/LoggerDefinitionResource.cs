using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.LoggerDefinition
{
    /// <summary>
    /// AWS::Greengrass::LoggerDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-loggerdefinition.html
    /// </summary>
    public class LoggerDefinitionResource : ResourceBase
    {
        public class LoggerDefinitionProperties
        {
            /// <summary>
            /// InitialVersion
            /// The logger definition version to include when the logger definition is created. A logger definition
            /// version contains a list of logger property types.
            /// 				
            /// Note To associate a logger definition version after the logger definition is created, 				 create an
            /// AWS::Greengrass::LoggerDefinitionVersion 				 resource and specify the ID of this logger definition.
            /// Required: No
            /// Type: LoggerDefinitionVersion
            /// Update requires: Replacement
            /// </summary>
            public LoggerDefinitionVersion InitialVersion { get; set; }

            /// <summary>
            /// Tags
            /// Application-specific metadata to attach to the logger definition. 		 You can use tags in IAM
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
            /// The name of the logger definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::LoggerDefinition";

        public LoggerDefinitionProperties Properties { get; } = new LoggerDefinitionProperties();

    }

    public static class LoggerDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
