using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig
    /// The AWS::SageMaker::EndpointConfig resource creates a configuration for an Amazon SageMaker endpoint. For more
    /// information, see CreateEndpointConfig in the SageMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html
    /// </summary>
    public class EndpointConfigResource : ResourceBase
    {
        public class EndpointConfigProperties
        {
            /// <summary>
            /// ProductionVariants
            /// A list of the production variants that specify the models you want to host at this endpoint.
            /// Required: Yes
            /// Type: List of Amazon SageMaker EndpointConfig ProductionVariant
            /// Update requires: Replacement
            /// </summary>
			public List<ProductionVariant> ProductionVariants { get; set; }

            /// <summary>
            /// KmsKeyId
            /// If you provide a AWS KMS key ID, Amazon SageMaker uses it to encrypt data at rest on the ML storage
            /// volume that is attached to your notebook instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// EndpointConfigName
            /// The name of the endpoint configuration.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointConfigName { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs. For more information, see Using Cost Allocation Tags in the AWS Billing
            /// and Cost Management User Guide.
            /// Required: Yes
            /// Type: List of Resource Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::EndpointConfig";

        public EndpointConfigProperties Properties { get; } = new EndpointConfigProperties();

    }

	public static class EndpointConfigAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EndpointConfigName = new ResourceAttribute<Union<string, IntrinsicFunction>>("EndpointConfigName");
	}
}
