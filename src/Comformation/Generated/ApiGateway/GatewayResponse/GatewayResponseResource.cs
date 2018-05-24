using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.GatewayResponse
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html
    /// </summary>
    public class GatewayResponseResource : ResourceBase
    {
        public class GatewayResponseProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html#cfn-apigateway-gatewayresponse-responseparameters
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> ResponseParameters { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html#cfn-apigateway-gatewayresponse-responsetemplates
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> ResponseTemplates { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html#cfn-apigateway-gatewayresponse-responsetype
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html#cfn-apigateway-gatewayresponse-restapiid
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html#cfn-apigateway-gatewayresponse-statuscode
            /// </summary>
			public Union<string, IntrinsicFunction> StatusCode { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::GatewayResponse";
        
        public GatewayResponseProperties Properties { get; } = new GatewayResponseProperties();
    }
}
