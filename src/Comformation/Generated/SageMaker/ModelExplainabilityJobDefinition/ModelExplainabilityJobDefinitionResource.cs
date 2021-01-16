using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html
    /// </summary>
    public class ModelExplainabilityJobDefinitionResource : ResourceBase
    {
        public class ModelExplainabilityJobDefinitionProperties
        {
            /// <summary>
            /// JobDefinitionName
            /// The name of the model explainability job definition. The name must be unique within an AWS Region in
            /// the AWS account.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobDefinitionName { get; set; }

            /// <summary>
            /// ModelExplainabilityBaselineConfig
            /// The baseline configuration for a model explainability job.
            /// Required: No
            /// Type: ModelExplainabilityBaselineConfig
            /// Update requires: Replacement
            /// </summary>
            public ModelExplainabilityBaselineConfig ModelExplainabilityBaselineConfig { get; set; }

            /// <summary>
            /// ModelExplainabilityAppSpecification
            /// Configures the model explainability job to run a specified Docker container image.
            /// Required: Yes
            /// Type: ModelExplainabilityAppSpecification
            /// Update requires: Replacement
            /// </summary>
            public ModelExplainabilityAppSpecification ModelExplainabilityAppSpecification { get; set; }

            /// <summary>
            /// ModelExplainabilityJobInput
            /// Inputs for the model explainability job.
            /// Required: Yes
            /// Type: ModelExplainabilityJobInput
            /// Update requires: Replacement
            /// </summary>
            public ModelExplainabilityJobInput ModelExplainabilityJobInput { get; set; }

            /// <summary>
            /// ModelExplainabilityJobOutputConfig
            /// The output configuration for monitoring jobs.
            /// Required: Yes
            /// Type: MonitoringOutputConfig
            /// Update requires: Replacement
            /// </summary>
            public MonitoringOutputConfig ModelExplainabilityJobOutputConfig { get; set; }

            /// <summary>
            /// JobResources
            /// Identifies the resources to deploy for a monitoring job.
            /// Required: Yes
            /// Type: MonitoringResources
            /// Update requires: Replacement
            /// </summary>
            public MonitoringResources JobResources { get; set; }

            /// <summary>
            /// NetworkConfig
            /// Networking options for a model explainability job.
            /// Required: No
            /// Type: NetworkConfig
            /// Update requires: Replacement
            /// </summary>
            public NetworkConfig NetworkConfig { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on
            /// your behalf.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// StoppingCondition
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: StoppingCondition
            /// Update requires: Replacement
            /// </summary>
            public StoppingCondition StoppingCondition { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::ModelExplainabilityJobDefinition";

        public ModelExplainabilityJobDefinitionProperties Properties { get; } = new ModelExplainabilityJobDefinitionProperties();

    }

    public static class ModelExplainabilityJobDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> JobDefinitionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("JobDefinitionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
