using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.BasePathMapping
{
    /// <summary>
    /// AWS::ApiGateway::BasePathMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-basepathmapping.html
    /// </summary>
    public class BasePathMappingResource : ResourceBase
    {
        public class BasePathMappingProperties
        {
            /// <summary>
            /// BasePath
            /// The base path name that callers of the API must provide in the URL after the domain name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BasePath { get; set; }

            /// <summary>
            /// DomainName
            /// The DomainName of an AWS::ApiGateway::DomainName resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// RestApiId
            /// The ID of the API.
            /// Required: No
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
