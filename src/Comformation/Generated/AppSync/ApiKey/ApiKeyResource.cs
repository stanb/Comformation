using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.ApiKey
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html
    /// </summary>
    public class ApiKeyResource : ResourceBase
    {
        public class ApiKeyProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-expires
            /// </summary>
			public Union<double, IntrinsicFunction> Expires { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-apiid
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

        }
    
        public string Type { get; } = "AWS::AppSync::ApiKey";
        
        public ApiKeyProperties Properties { get; } = new ApiKeyProperties();
    }

	public static class ApiKeyAttributes
	{
        public static readonly ResourceAttribute<string> ApiKey = new ResourceAttribute<string>("ApiKey");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
