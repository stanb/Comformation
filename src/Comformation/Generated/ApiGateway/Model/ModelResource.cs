using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Model
{
    /// <summary>
    /// AWS::ApiGateway::Model
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-model.html
    /// </summary>
    public class ModelResource : ResourceBase
    {
        public class ModelProperties
        {
            /// <summary>
            /// ContentType
            /// The content type for the model.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ContentType { get; set; }

            /// <summary>
            /// Description
            /// A description that identifies this model.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// A name for the model. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the model name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RestApiId
            /// The ID of a REST API with which to associate this model.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// Schema
            /// The schema to use to transform data to one or more output formats. Specify null ({}) if you don&#39;t
            /// want to specify a schema.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Schema { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::Model";

        public ModelProperties Properties { get; } = new ModelProperties();

    }
}
