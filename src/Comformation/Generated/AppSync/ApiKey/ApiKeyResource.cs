using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.ApiKey
{
    /// <summary>
    /// AWS::AppSync::ApiKey
    /// The AWS::AppSync::ApiKey resource creates a unique key that you can distribute to clients who are executing
    /// GraphQL operations with AWS AppSync that require an API key.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html
    /// </summary>
    public class ApiKeyResource : ResourceBase
    {
        public class ApiKeyProperties
        {
            /// <summary>
            /// Description
            /// Unique description of your API Key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Expires
            /// Expiration time of the API Key in seconds (using Unix Epoch time), with a minimum of 1 day and a
            /// maximum of 365 days.
            /// Required: Yes
            /// Type: Number
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-expires
            /// </summary>
			public Union<double, IntrinsicFunction> Expires { get; set; }

            /// <summary>
            /// ApiId
            /// Unique AWS AppSync GraphQL API Identifier for this API Key.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html#cfn-appsync-apikey-apiid
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
