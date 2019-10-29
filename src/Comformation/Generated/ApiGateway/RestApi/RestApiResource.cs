using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.RestApi
{
    /// <summary>
    /// AWS::ApiGateway::RestApi
    /// The AWS::ApiGateway::RestApi resource creates a REST API. For more information, see restapi:create in the
    /// Amazon API Gateway REST API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-restapi.html
    /// </summary>
    public class RestApiResource : ResourceBase
    {
        public class RestApiProperties
        {
            /// <summary>
            /// ApiKeySourceType
            /// The source of the API key for metering requests according to a usage plan. Valid values are:
            /// HEADER to read the API key from the X-API-Key header of a request. AUTHORIZER to read the API key
            /// from the UsageIdentifierKey from a Lambda authorizer.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApiKeySourceType { get; set; }

            /// <summary>
            /// BinaryMediaTypes
            /// The list of binary media types that are supported by the RestApi resource, such as image/png or
            /// application/octet-stream. By default, RestApi supports only UTF-8-encoded text payloads. Duplicates
            /// are not allowed. Slashes must be escaped with ~1. For example, image/png would be image~1png in the
            /// BinaryMediaTypes list. For more information, see Enable Support for Binary Payloads in API Gateway
            /// in the API Gateway Developer Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> BinaryMediaTypes { get; set; }

            /// <summary>
            /// Body
            /// An OpenAPI specification that defines a set of RESTful APIs in JSON format. For YAML templates, you
            /// can also provide the specification in YAML format.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Body { get; set; }

            /// <summary>
            /// BodyS3Location
            /// The Amazon Simple Storage Service (Amazon S3) location that points to an OpenAPI file, which defines
            /// a set of RESTful APIs in JSON or YAML format.
            /// Required: No
            /// Type: S3Location
            /// Update requires: No interruption
            /// </summary>
			public S3Location BodyS3Location { get; set; }

            /// <summary>
            /// CloneFrom
            /// The ID of the RestApi resource that you want to clone.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CloneFrom { get; set; }

            /// <summary>
            /// Description
            /// A description of the RestApi resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EndpointConfiguration
            /// A list of the endpoint types of the API. Use this property when creating an API. When importing an
            /// existing API, specify the endpoint configuration types using the Parameters property.
            /// Required: No
            /// Type: EndpointConfiguration
            /// Update requires: No interruption
            /// </summary>
			public EndpointConfiguration EndpointConfiguration { get; set; }

            /// <summary>
            /// FailOnWarnings
            /// Indicates whether to roll back the resource if a warning occurs while API Gateway is creating the
            /// RestApi resource.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
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
            /// </summary>
			public Union<int, IntrinsicFunction> MinimumCompressionSize { get; set; }

            /// <summary>
            /// Name
            /// A name for the RestApi resource.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Parameters
            /// Custom header parameters for the request.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

            /// <summary>
            /// Policy
            /// A policy document that contains the permissions for the RestApi resource, in JSON format. To set the
            /// ARN for the policy, use the !Join intrinsic function with &quot;&quot; as delimiter and values of
            /// &quot;execute-api:/&quot; and &quot;*&quot;.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Policy { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::RestApi";

        public RestApiProperties Properties { get; } = new RestApiProperties();

    }

	public static class RestApiAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RootResourceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RootResourceId");
	}
}
