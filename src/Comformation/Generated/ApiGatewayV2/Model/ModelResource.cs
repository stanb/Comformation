using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Model
{
    /// <summary>
    /// AWS::ApiGatewayV2::Model
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-model.html
    /// </summary>
    public class ModelResource : ResourceBase
    {
        public class ModelProperties
        {
            /// <summary>
            /// Description
            /// The description of the model.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ContentType
            /// The content-type for the model, for example, &quot;application/json&quot;.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ContentType { get; set; }

            /// <summary>
            /// Schema
            /// The schema for the model. For application/json models, this should be JSON schema draft 4 model.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Schema { get; set; }

            /// <summary>
            /// ApiId
            /// The API identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// The name of the model.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Model";

        public ModelProperties Properties { get; } = new ModelProperties();

    }
}
