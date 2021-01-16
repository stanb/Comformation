using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html
    /// </summary>
    public class EndpointConfigResource : ResourceBase
    {
        public class EndpointConfigProperties
        {
            /// <summary>
            /// DataCaptureConfig
            /// Specifies how to capture endpoint data for model monitor. The data capture configuration applies to
            /// all production variants hosted at the endpoint.
            /// Required: No
            /// Type: DataCaptureConfig
            /// Update requires: Replacement
            /// </summary>
            public DataCaptureConfig DataCaptureConfig { get; set; }

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
            /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab Key ARN:
            /// arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab Alias name:
            /// alias/ExampleAlias Alias name ARN: arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias
            /// The KMS key policy must grant permission to the IAM role that you specify in your CreateEndpoint,
            /// UpdateEndpoint requests. For more information, refer to the AWS Key Management Service section Using
            /// Key Policies in AWS KMS
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
            /// The name of the endpoint configuration.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
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
