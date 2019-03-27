using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Model
{
    /// <summary>
    /// AWS::ApiGatewayV2::Model
    /// The AWS::ApiGatewayV2::Model resource define a data model for an API. For more information, see CreateModel in
    /// the Amazon API Gateway V2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-model.html
    /// </summary>
    public class ModelResource : ResourceBase
    {
        public class ModelProperties
        {
            /// <summary>
            /// Description
            /// A description that identifies this model.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ContentType
            /// The content type for the model.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ContentType { get; set; }

            /// <summary>
            /// Schema
            /// The schema to use to transform data to one or more output formats. Specify null ({}) if you don&#39;t
            /// want to specify a schema.
            /// Required: Yes
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Schema { get; set; }

            /// <summary>
            /// ApiId
            /// The ID of the API with which to associate this model.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// A name for the model. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the model name. For more information, see Name Type.
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
