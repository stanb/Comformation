using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html
    /// </summary>
    public class ResolverResource : ResourceBase
    {
        public class ResolverProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplates3location
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseMappingTemplateS3Location { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-typename
            /// </summary>
			public Union<string, IntrinsicFunction> TypeName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-datasourcename
            /// </summary>
			public Union<string, IntrinsicFunction> DataSourceName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplate
            /// </summary>
			public Union<string, IntrinsicFunction> RequestMappingTemplate { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplate
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseMappingTemplate { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplates3location
            /// </summary>
			public Union<string, IntrinsicFunction> RequestMappingTemplateS3Location { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-apiid
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-fieldname
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
