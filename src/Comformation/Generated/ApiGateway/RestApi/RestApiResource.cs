using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.RestApi
{
    /// <summary>
    /// AWS::ApiGateway::RestApi
    /// The AWS::ApiGateway::RestApi resource contains a collection of Amazon API Gateway resources and methods that
    /// can be invoked through HTTPS endpoints. For more information, see restapi:create in the Amazon API Gateway
    /// REST API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html
    /// </summary>
    public class RestApiResource : ResourceBase
    {
        public class RestApiProperties
        {
            /// <summary>
            /// ApiKeySourceType
            /// The source of the API key for metering requests according to a usage plan. Valid values are:
            /// HEADER to read the API key from the X-API-Key header of a request. AUTHORIZER to read the API key
            /// from the UsageIdentifierKey from a custom authorizer.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-apikeysourcetype
            /// </summary>
			public Union<string, IntrinsicFunction> ApiKeySourceType { get; set; }

            /// <summary>
            /// BinaryMediaTypes
            /// The list of binary media types that are supported by the RestApi resource, such as image/png or
            /// application/octet-stream. By default, RestApi supports only UTF-8-encoded text payloads. For more
            /// information, see Enable Support for Binary Payloads in API Gateway in the API Gateway Developer
            /// Guide. Duplicates are not allowed.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-binarymediatypes
            /// </summary>
			public Union<List<string>, IntrinsicFunction> BinaryMediaTypes { get; set; }

            /// <summary>
            /// Body
            /// An OpenAPI specification that defines a set of RESTful APIs in the JSON format. For YAML templates,
            /// you can also provide the specification in the YAML format.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-body
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Body { get; set; }

            /// <summary>
            /// BodyS3Location
            /// The Amazon Simple Storage Service (Amazon S3) location that points to an OpenAPI file, which defines
            /// a set of RESTful APIs in JSON or YAML format.
            /// Required: No
            /// Type: Amazon API Gateway RestApi S3Location
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-bodys3location
            /// </summary>
			public Union<S3Location, IntrinsicFunction> BodyS3Location { get; set; }

            /// <summary>
            /// CloneFrom
            /// The ID of the API Gateway RestApi resource that you want to clone.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-clonefrom
            /// </summary>
			public Union<string, IntrinsicFunction> CloneFrom { get; set; }

            /// <summary>
            /// Description
            /// A description of the purpose of this API Gateway RestApi resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EndpointConfiguration
            /// A list of the endpoint types of the API. Use this property when creating an API. When importing an
            /// existing API, specify the endpoint configuration types using the Parameters property.
            /// Required: No
            /// Type: API Gateway RestApi EndpointConfiguration
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-endpointconfiguration
            /// </summary>
			public Union<EndpointConfiguration, IntrinsicFunction> EndpointConfiguration { get; set; }

            /// <summary>
            /// FailOnWarnings
            /// Indicates whether to roll back the resource if a warning occurs while API Gateway is creating the
            /// RestApi resource.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-failonwarning
            /// </summary>
			public Union<bool, IntrinsicFunction> FailOnWarnings { get; set; }

            /// <summary>
            /// MinimumCompressionSize
            /// A nullable integer that is used to enable compression (with non-negative between 0 and 10485760
            /// (10M) bytes, inclusive) or disable compression (with a null value) on an API. When compression is
            /// enabled, compression or decompression is not applied on the payload if the payload size is smaller
            /// than this value. Setting it to zero allows compression for any payload size.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-minimumcompressionsize
            /// </summary>
			public Union<int, IntrinsicFunction> MinimumCompressionSize { get; set; }

            /// <summary>
            /// Name
            /// A name for the API Gateway RestApi resource.
            /// Required: Conditional. Required if you don't specify a OpenAPI definition.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Parameters
            /// Custom header parameters for the request.
            /// For more information on specifying parameters when importing an API, see import-rest-api operation
            /// in the AWS CLI Command Reference.
            /// Required: No
            /// Type: String to String map
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-parameters
            /// </summary>
			public Union<Dictionary<string, string>, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Policy
            /// A policy document that contains the permissions for this RestApi resource, in JSON format.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html#cfn-apigateway-restapi-policy
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Policy { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::RestApi";
        
        public RestApiProperties Properties { get; } = new RestApiProperties();
    }

	public static class RestApiAttributes
	{
        public static readonly ResourceAttribute<string> RootResourceId = new ResourceAttribute<string>("RootResourceId");
	}
}
