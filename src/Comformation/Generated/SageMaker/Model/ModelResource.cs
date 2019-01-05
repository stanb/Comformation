using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model
    /// The AWS::SageMaker::Model resource to create a model to host at an Amazon SageMaker endpoint. For more
    /// information, see Deploying a Model on Amazon SageMaker Hosting Services in the Amazon SageMaker Developer
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html
    /// </summary>
    public class ModelResource : ResourceBase
    {
        public class ModelProperties
        {
            /// <summary>
            /// ExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker can assume to access model
            /// artifacts and docker image for deployment on ML compute instances. Deploying on ML compute instances
            /// is part of model hosting. For more information, see Amazon SageMaker Roles.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// PrimaryContainer
            /// The location of the primary docker image containing inference code, associated artifacts, and custom
            /// environment map that the inference code uses when the model is deployed into production.
            /// Required: Yes
            /// Type: Amazon SageMaker Model ContainerDefinition
            /// Update requires: Replacement
            /// </summary>
			public ContainerDefinition PrimaryContainer { get; set; }

            /// <summary>
            /// ModelName
            /// The name of the model.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ModelName { get; set; }

            /// <summary>
            /// VpcConfig
            /// A VpcConfig object that specifies the VPC that you want your model to connect to. Control access to
            /// and from your model container by configuring the VPC. For more information, see Protect Models by
            /// Using an Amazon Virtual Private Cloud.
            /// Required: No
            /// Type: Amazon SageMaker Model VpcConfig
            /// Update requires: Replacement
            /// </summary>
			public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// Containers
            /// Specifies the containers in the inference pipeline.
            /// Required: No
            /// Type: List of Amazon SageMaker Model ContainerDefinition
            /// Update requires: Replacement
            /// </summary>
			public List<ContainerDefinition> Containers { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs. For more information, see Using Cost Allocation Tags in the AWS Billing
            /// and Cost Management User Guide.
            /// Required: No
            /// Type: List of Resource Tag
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
