using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DocumentationVersion
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html
    /// </summary>
    public class DocumentationVersionResource : ResourceBase
    {
        public class DocumentationVersionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-documentationversion
            /// </summary>
			public Union<string, IntrinsicFunction> DocumentationVersion { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-restapiid
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::DocumentationVersion";
        
        public DocumentationVersionProperties Properties { get; } = new DocumentationVersionProperties();
    }
}
