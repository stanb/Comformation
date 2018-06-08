using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS::AppSync::Resolver
    /// The AWS::AppSync::Resolver resource defines the logical GraphQL resolver that you will attach to fields in a
    /// schema. Request and Response templates for resolvers are written in Apache Velocity Template Language (VTL)
    /// format. More information on resolvers can be found in the Resolver Mapping Template Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html
    /// </summary>
    public class ResolverResource : ResourceBase
    {
        public class ResolverProperties
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
            /// TypeName
            /// The GraphQL type that will invoke this resolver.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TypeName { get; set; }

            /// <summary>
            /// DataSourceName
            /// The AWS AppSync data source that this resolver will run against in order to return data to the
            /// caller.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DataSourceName { get; set; }

            /// <summary>
            /// RequestMappingTemplate
            /// The resolver’s request mapping template, written in text within the CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RequestMappingTemplate { get; set; }

            /// <summary>
            /// ResponseMappingTemplate
            /// The resolver’s response mapping template, written in text within the CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseMappingTemplate { get; set; }

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
            /// The AWS AppSync GraphQL API which you will attach this resolver.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// FieldName
            /// The GraphQL field on a type that will invoke the resolver.
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
        public static readonly ResourceAttribute<string> TypeName = new ResourceAttribute<string>("TypeName");
        public static readonly ResourceAttribute<string> ResolverArn = new ResourceAttribute<string>("ResolverArn");
        public static readonly ResourceAttribute<string> FieldName = new ResourceAttribute<string>("FieldName");
	}
}
