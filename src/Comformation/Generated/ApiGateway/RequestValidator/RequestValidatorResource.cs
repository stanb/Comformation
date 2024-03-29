using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.RequestValidator
{
    /// <summary>
    /// AWS::ApiGateway::RequestValidator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-requestvalidator.html
    /// </summary>
    public class RequestValidatorResource : ResourceBase
    {
        public class RequestValidatorProperties
        {
            /// <summary>
            /// Name
            /// The name of this request validator.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RestApiId
            /// The identifier of the targeted API entity.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// ValidateRequestBody
            /// Indicates whether to validate the request body according to the configured schema for the targeted
            /// API and method.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ValidateRequestBody { get; set; }

            /// <summary>
            /// ValidateRequestParameters
            /// Indicates whether to validate request parameters.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ValidateRequestParameters { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::RequestValidator";

        public RequestValidatorProperties Properties { get; } = new RequestValidatorProperties();

    }

    public static class RequestValidatorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RequestValidatorId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RequestValidatorId");
    }
}
