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
            /// A list of ProductionVariant objects, one for each model that you want to host at this endpoint.
            /// Required: Yes
            /// Type: List of ProductionVariant
            /// Maximum: 10
            /// Update requires: Replacement
            /// </summary>
			public List<ProductionVariant> ProductionVariants { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker uses to
            /// encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.
            /// Note Certain Nitro-based instances include local storage, dependent on the instance type. Local
            /// storage volumes are encrypted using a hardware module on the instance. You can&#39;t request a KmsKeyId
            /// when using an instance type with local storage. If any of the models that you specify in the
            /// ProductionVariants parameter use nitro-based instances with local storage, do not specify a value
            /// for the KmsKeyId parameter. If you specify a value for KmsKeyId when using any nitro-based instances
            /// with local storage, the call to CreateEndpointConfig fails. For a list of instance types that
            /// support local instance storage, see Instance Store Volumes. For more information about local
            /// instance storage encryption, see SSD Instance Store Volumes.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Pattern: . *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// EndpointConfigName
            /// The name of the endpoint configuration. You specify this name in a CreateEndpoint request.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointConfigName { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs to apply to this resource.
            /// For more information, see Resource Tag and Using Cost Allocation Tags.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
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
