using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html
    /// </summary>
    public class EndpointResource : ResourceBase
    {
        public class EndpointProperties
        {
            /// <summary>
            /// RetainAllVariantProperties
            /// When updating endpoint resources, enables or disables the retention of variant properties, such as
            /// the instance count or the variant weight. To retain the variant properties of an endpoint when
            /// updating it, set RetainAllVariantProperties to true. To use the variant properties specified in a
            /// new EndpointConfig call when updating an endpoint, set RetainAllVariantProperties to false. Use this
            /// property only when updating endpoint resources, not when creating new endpoint resources.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> RetainAllVariantProperties { get; set; }

            /// <summary>
            /// EndpointName
            /// The name of the endpoint. The name must be unique within an AWS Region in your AWS account. The name
            /// is case-insensitive in CreateEndpoint, but the case is preserved and must be matched in
            /// https://docs. aws. amazon. com/sagemaker/latest/APIReference/API_runtime_InvokeEndpoint. html.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointName { get; set; }

            /// <summary>
            /// ExcludeRetainedVariantProperties
            /// When you are updating endpoint resources with RetainAllVariantProperties whose value is set to true,
            /// ExcludeRetainedVariantProperties specifies the list of type VariantProperty to override with the
            /// values provided by EndpointConfig. If you don&#39;t specify a value for ExcludeAllVariantProperties, no
            /// variant properties are overridden. Don&#39;t use this property when creating new endpoint resources or
            /// when RetainAllVariantProperties is set to false.
            /// Required: No
            /// Type: List of VariantProperty
            /// Maximum: 3
            /// Update requires: No interruption
            /// </summary>
            public List<VariantProperty> ExcludeRetainedVariantProperties { get; set; }

            /// <summary>
            /// EndpointConfigName
            /// The name of the AWS::SageMaker::EndpointConfig resource that specifies the configuration for the
            /// endpoint. For more information, see CreateEndpointConfig.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointConfigName { get; set; }

            /// <summary>
            /// DeploymentConfig
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: DeploymentConfig
            /// Update requires: No interruption
            /// </summary>
            public DeploymentConfig DeploymentConfig { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs to apply to this resource.
            /// For more information, see Resource Tag and Using Cost Allocation Tags in the AWS Billing and Cost
            /// Management User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Endpoint";

        public EndpointProperties Properties { get; } = new EndpointProperties();

    }

    public static class EndpointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EndpointName = new ResourceAttribute<Union<string, IntrinsicFunction>>("EndpointName");
    }
}
