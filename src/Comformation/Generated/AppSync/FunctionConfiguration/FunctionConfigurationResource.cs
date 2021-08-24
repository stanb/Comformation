using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.FunctionConfiguration
{
    /// <summary>
    /// AWS::AppSync::FunctionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html
    /// </summary>
    public class FunctionConfigurationResource : ResourceBase
    {
        public class FunctionConfigurationProperties
        {
            /// <summary>
            /// ResponseMappingTemplateS3Location
            /// The location of a response mapping template in an Amazon S3 bucket. Use this if you want to
            /// provision with a template file in Amazon S3 rather than embedding it in your CloudFormation
            /// template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResponseMappingTemplateS3Location { get; set; }

            /// <summary>
            /// Description
            /// The Function description.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DataSourceName
            /// The name of data source this function will attach.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DataSourceName { get; set; }

            /// <summary>
            /// RequestMappingTemplate
            /// The Function request mapping template. Functions support only the 2018-05-29 version of the request
            /// mapping template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequestMappingTemplate { get; set; }

            /// <summary>
            /// ResponseMappingTemplate
            /// The Function response mapping template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResponseMappingTemplate { get; set; }

            /// <summary>
            /// FunctionVersion
            /// The version of the request mapping template. Currently only the 2018-05-29 version of the template
            /// is supported.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionVersion { get; set; }

            /// <summary>
            /// SyncConfig
            /// Describes a Sync configuration for a resolver.
            /// Contains information on which Conflict Detection as well as Resolution strategy should be performed
            /// when the resolver is invoked.
            /// Required: No
            /// Type: SyncConfig
            /// Update requires: No interruption
            /// </summary>
            public SyncConfig SyncConfig { get; set; }

            /// <summary>
            /// RequestMappingTemplateS3Location
            /// Describes a Sync configuration for a resolver.
            /// Contains information on which Conflict Detection, as well as Resolution strategy, should be
            /// performed when the resolver is invoked.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequestMappingTemplateS3Location { get; set; }

            /// <summary>
            /// ApiId
            /// The AWS AppSync GraphQL API that you want to attach using this function.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// The name of the function.
            /// Required: Yes
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
