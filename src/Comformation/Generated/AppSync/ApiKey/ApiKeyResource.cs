using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.ApiKey
{
    /// <summary>
    /// AWS::AppSync::ApiKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-apikey.html
    /// </summary>
    public class ApiKeyResource : ResourceBase
    {
        public class ApiKeyProperties
        {
            /// <summary>
            /// Description
            /// Unique description of your API key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ApiKeyId
            /// The API key ID.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApiKeyId { get; set; }

            /// <summary>
            /// Expires
            /// The time after which the API key expires. The date is represented as seconds since the epoch,
            /// rounded down to the nearest hour.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> Expires { get; set; }

            /// <summary>
            /// ApiId
            /// Unique AWS AppSync GraphQL API ID for this API key.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

        }

        public string Type { get; } = "AWS::AppSync::ApiKey";

        public ApiKeyProperties Properties { get; } = new ApiKeyProperties();

    }

    public static class ApiKeyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApiKey = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApiKey");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
