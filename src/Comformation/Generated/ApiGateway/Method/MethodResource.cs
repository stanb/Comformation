using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Method
{
    /// <summary>
    /// AWS::ApiGateway::Method
    /// The AWS::ApiGateway::Method resource creates Amazon API Gateway (API Gateway) methods that define the
    /// parameters and body that clients must send in their requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html
    /// </summary>
    public class MethodResource : ResourceBase
    {
        public class MethodProperties
        {
            /// <summary>
            /// ApiKeyRequired
            /// Indicates whether the method requires clients to submit a valid API key.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> ApiKeyRequired { get; set; }

            /// <summary>
            /// AuthorizationType
            /// The method's authorization type.
            /// Required: Yes. If you specify the AuthorizerId property, specify CUSTOM for this property.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizationType { get; set; }

            /// <summary>
            /// AuthorizerId
            /// The identifier of the authorizer to use on this method. If you specify this property, specify CUSTOM
            /// for the AuthorizationType property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerId { get; set; }

            /// <summary>
            /// HttpMethod
            /// The HTTP method that clients use to call this method.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HttpMethod { get; set; }

            /// <summary>
            /// Integration
            /// The backend system that the method calls when it receives a request.
            /// Required: No
            /// Type: Amazon API Gateway Method Integration
            /// Update requires: No interruption
            /// </summary>
			public Union<Integration, IntrinsicFunction> Integration { get; set; }

            /// <summary>
            /// MethodResponses
            /// The responses that can be sent to the client who calls the method.
            /// Required: No
            /// Type: List of Amazon API Gateway Method MethodResponse property types.
            /// Update requires: No interruption
            /// </summary>
			public Union<List<MethodResponse>, IntrinsicFunction> MethodResponses { get; set; }

            /// <summary>
            /// OperationName
            /// A friendly operation name for the method. For example, you can assign the OperationName of ListPets
            /// for the GET /pets method.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> OperationName { get; set; }

            /// <summary>
            /// RequestModels
            /// The resources that are used for the response's content type. Specify response models as key-value
            /// pairs (string-to-string mapping), with a content type as the key and a Model resource name as the
            /// value.
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> RequestModels { get; set; }

            /// <summary>
            /// RequestParameters
            /// The request parameters that API Gateway accepts. Specify request parameters as key-value pairs
            /// (string-to-Boolean mapping), with a source as the key and a Boolean as the value. The Boolean
            /// specifies whether a parameter is required. A source must match the format method. request. location.
            /// name, where the location is querystring, path, or header, and name is a valid, unique parameter
            /// name.
            /// Required: No
            /// Type: Mapping of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Union<Dictionary<string, bool>, IntrinsicFunction> RequestParameters { get; set; }

            /// <summary>
            /// RequestValidatorId
            /// The ID of the associated request validator.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RequestValidatorId { get; set; }

            /// <summary>
            /// ResourceId
            /// The ID of an API Gateway resource. For root resource methods, specify the RestApi root resource ID,
            /// such as { "Fn::GetAtt": ["MyRestApi", "RootResourceId"] }.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// RestApiId
            /// The ID of the RestApi resource in which API Gateway creates the method.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::Method";
        
        public MethodProperties Properties { get; } = new MethodProperties();
    }
}
