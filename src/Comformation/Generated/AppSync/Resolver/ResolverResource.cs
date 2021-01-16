using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS::AppSync::Resolver
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html
    /// </summary>
    public class ResolverResource : ResourceBase
    {
        public class ResolverProperties
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
            /// TypeName
            /// The GraphQL type that invokes this resolver.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TypeName { get; set; }

            /// <summary>
            /// PipelineConfig
            /// Functions linked with the pipeline resolver.
            /// Required: No
            /// Type: PipelineConfig
            /// Update requires: No interruption
            /// </summary>
            public PipelineConfig PipelineConfig { get; set; }

            /// <summary>
            /// DataSourceName
            /// The resolver data source name.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DataSourceName { get; set; }

            /// <summary>
            /// RequestMappingTemplate
            /// The request mapping template.
            /// Request mapping templates are optional when using a Lambda data source. For all other data sources,
            /// a request mapping template is required.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequestMappingTemplate { get; set; }

            /// <summary>
            /// ResponseMappingTemplate
            /// The response mapping template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResponseMappingTemplate { get; set; }

            /// <summary>
            /// Kind
            /// The resolver type.
            /// UNIT: A UNIT resolver type. A UNIT resolver is the default resolver type. A UNIT resolver enables
            /// you to execute a GraphQL query against a single data source. PIPELINE: A PIPELINE resolver type. A
            /// PIPELINE resolver enables you to execute a series of Function in a serial manner. You can use a
            /// pipeline resolver to execute a GraphQL query against multiple data sources.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Kind { get; set; }

            /// <summary>
            /// CachingConfig
            /// The caching configuration for the resolver.
            /// Required: No
            /// Type: CachingConfig
            /// Update requires: No interruption
            /// </summary>
            public CachingConfig CachingConfig { get; set; }

            /// <summary>
            /// SyncConfig
            /// The SyncConfig for a resolver attached to a versioned datasource.
            /// Required: No
            /// Type: SyncConfig
            /// Update requires: No interruption
            /// </summary>
            public SyncConfig SyncConfig { get; set; }

            /// <summary>
            /// RequestMappingTemplateS3Location
            /// The location of a request mapping template in an Amazon S3 bucket. Use this if you want to provision
            /// with a template file in Amazon S3 rather than embedding it in your CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RequestMappingTemplateS3Location { get; set; }

            /// <summary>
            /// ApiId
            /// The AWS AppSync GraphQL API to which you want to attach this resolver.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// FieldName
            /// The GraphQL field on a type that invokes the resolver.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FieldName { get; set; }

        }

        public string Type { get; } = "AWS::AppSync::Resolver";

        public ResolverProperties Properties { get; } = new ResolverProperties();

    }

    public static class ResolverAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TypeName = new ResourceAttribute<Union<string, IntrinsicFunction>>("TypeName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResolverArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResolverArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FieldName = new ResourceAttribute<Union<string, IntrinsicFunction>>("FieldName");
    }
}
