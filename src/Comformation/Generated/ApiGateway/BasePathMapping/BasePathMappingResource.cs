using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.BasePathMapping
{
    /// <summary>
    /// AWS::ApiGateway::BasePathMapping
    /// The AWS::ApiGateway::BasePathMapping resource creates a base path that clients who call your Amazon API
    /// Gateway API must use in the invocation URL.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-basepathmapping.html
    /// </summary>
    public class BasePathMappingResource : ResourceBase
    {
        public class BasePathMappingProperties
        {
            /// <summary>
            /// BasePath
            /// The base path name that callers of the API must provide in the URL after the domain name. If you
            /// specify this property, it can&#39;t be an empty string.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BasePath { get; set; }

            /// <summary>
            /// DomainName
            /// The domain name of a DomainName resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// RestApiId
            /// The name of the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// Stage
            /// The name of the API&#39;s stage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Stage { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::BasePathMapping";
        
        public BasePathMappingProperties Properties { get; } = new BasePathMappingProperties();
    }
}
