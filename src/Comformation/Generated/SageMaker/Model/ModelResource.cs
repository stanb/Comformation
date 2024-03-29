using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html
    /// </summary>
    public class ModelResource : ResourceBase
    {
        public class ModelProperties
        {
            /// <summary>
            /// ExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker can assume to access model
            /// artifacts and docker image for deployment on ML compute instances or for batch transform jobs.
            /// Deploying on ML compute instances is part of model hosting. For more information, see Amazon
            /// SageMaker Roles.
            /// Note To be able to pass this role to Amazon SageMaker, the caller of this API must have the
            /// iam:PassRole permission.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// EnableNetworkIsolation
            /// Isolates the model container. No inbound or outbound network calls can be made to or from the model
            /// container.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableNetworkIsolation { get; set; }

            /// <summary>
            /// PrimaryContainer
            /// The location of the primary docker image containing inference code, associated artifacts, and custom
            /// environment map that the inference code uses when the model is deployed for predictions.
            /// Required: No
            /// Type: ContainerDefinition
            /// Update requires: Replacement
            /// </summary>
            public ContainerDefinition PrimaryContainer { get; set; }

            /// <summary>
            /// ModelName
            /// The name of the new model.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModelName { get; set; }

            /// <summary>
            /// VpcConfig
            /// A VpcConfig object that specifies the VPC that you want your model to connect to. Control access to
            /// and from your model container by configuring the VPC. VpcConfig is used in hosting services and in
            /// batch transform. For more information, see Protect Endpoints by Using an Amazon Virtual Private
            /// Cloud and Protect Data in Batch Transform Jobs by Using an Amazon Virtual Private Cloud.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: Replacement
            /// </summary>
            public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// Containers
            /// Specifies the containers in the inference pipeline.
            /// Required: No
            /// Type: List of ContainerDefinition
            /// Maximum: 15
            /// Update requires: Replacement
            /// </summary>
            public List<ContainerDefinition> Containers { get; set; }

            /// <summary>
            /// InferenceExecutionConfig
            /// Specifies details of how containers in a multi-container endpoint are called.
            /// Required: No
            /// Type: InferenceExecutionConfig
            /// Update requires: Replacement
            /// </summary>
            public InferenceExecutionConfig InferenceExecutionConfig { get; set; }

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

        public string Type { get; } = "AWS::SageMaker::Model";

        public ModelProperties Properties { get; } = new ModelProperties();

    }

    public static class ModelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ModelName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ModelName");
    }
}
