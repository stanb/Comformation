using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DocumentationPart
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html
    /// </summary>
    public class DocumentationPartResource : ResourceBase
    {
        public class DocumentationPartProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-location
            /// </summary>
			public Union<Location, IntrinsicFunction> Location { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-properties
            /// </summary>
			public Union<string, IntrinsicFunction> Properties { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-restapiid
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::DocumentationPart";
        
        public DocumentationPartProperties Properties { get; } = new DocumentationPartProperties();
    }
}
