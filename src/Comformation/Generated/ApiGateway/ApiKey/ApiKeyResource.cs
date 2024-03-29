using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.ApiKey
{
    /// <summary>
    /// AWS::ApiGateway::ApiKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-apikey.html
    /// </summary>
    public class ApiKeyResource : ResourceBase
    {
        public class ApiKeyProperties
        {
            /// <summary>
            /// CustomerId
            /// An AWS Marketplace customer identifier to use when integrating with the AWS SaaS Marketplace.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CustomerId { get; set; }

            /// <summary>
            /// Description
            /// A description of the purpose of the API key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Enabled
            /// Indicates whether the API key can be used by clients.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// GenerateDistinctId
            /// Specifies whether the key identifier is distinct from the created API key value. This parameter is
            /// deprecated and should not be used.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> GenerateDistinctId { get; set; }

            /// <summary>
            /// Name
            /// A name for the API key. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical
            /// ID and uses that ID for the API key name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// StageKeys
            /// A list of stages to associate with this API key.
            /// Required: No
            /// Type: List of StageKey
            /// Update requires: No interruption
            /// </summary>
            public List<StageKey> StageKeys { get; set; }

            /// <summary>
            /// Tags
            /// An array of arbitrary tags (key-value pairs) to associate with the API key.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Value
            /// The value of the API key. Must be at least 20 characters long.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Value { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::ApiKey";

        public ApiKeyProperties Properties { get; } = new ApiKeyProperties();

    }

    public static class ApiKeyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> APIKeyId = new ResourceAttribute<Union<string, IntrinsicFunction>>("APIKeyId");
    }
}
