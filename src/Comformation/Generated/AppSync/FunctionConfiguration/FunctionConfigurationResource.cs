using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.FunctionConfiguration
{
    /// <summary>
    /// AWS::AppSync::FunctionConfiguration
    /// The AWS::AppSync::FunctionConfiguration resource defines the functions in GraphQL Apis to perform certain
    /// operations. Functions can be attached by PipelineResolver. More information on functions can be found in the
    /// FunctionConfiguration Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html
    /// </summary>
    public class FunctionConfigurationResource : ResourceBase
    {
        public class FunctionConfigurationProperties
        {
            /// <summary>
            /// ResponseMappingTemplateS3Location
            /// A location of a response mapping template on an S3 bucket if you wish to provision with the template
            /// file living in S3 rather than embedded in your CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseMappingTemplateS3Location { get; set; }

            /// <summary>
            /// Description
            /// The Description of the function.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DataSourceName
            /// The AWS AppSync data source that this function will run against in order to return data to the
            /// caller.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DataSourceName { get; set; }

            /// <summary>
            /// RequestMappingTemplate
            /// The function’s request mapping template, written in text within the CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RequestMappingTemplate { get; set; }

            /// <summary>
            /// ResponseMappingTemplate
            /// The function’s response mapping template, written in text within the CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseMappingTemplate { get; set; }

            /// <summary>
            /// FunctionVersion
            /// The version of the function.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionVersion { get; set; }

            /// <summary>
            /// RequestMappingTemplateS3Location
            /// A location of a request mapping template on an S3 bucket if you wish to provision with the template
            /// file living in S3 rather than embedded in your CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RequestMappingTemplateS3Location { get; set; }

            /// <summary>
            /// ApiId
            /// The AWS AppSync GraphQL API which you will attach with this function.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// The Name of the function.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::AppSync::FunctionConfiguration";

        public FunctionConfigurationProperties Properties { get; } = new FunctionConfigurationProperties();

    }

	public static class FunctionConfigurationAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FunctionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("FunctionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FunctionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("FunctionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DataSourceName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DataSourceName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
