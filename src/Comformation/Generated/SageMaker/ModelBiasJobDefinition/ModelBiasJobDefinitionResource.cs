using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html
    /// </summary>
    public class ModelBiasJobDefinitionResource : ResourceBase
    {
        public class ModelBiasJobDefinitionProperties
        {
            /// <summary>
            /// JobDefinitionName
            /// The name of the bias job definition. The name must be unique within an AWS Region in the AWS
            /// account.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobDefinitionName { get; set; }

            /// <summary>
            /// ModelBiasBaselineConfig
            /// The baseline configuration for a model bias job.
            /// Required: No
            /// Type: ModelBiasBaselineConfig
            /// Update requires: Replacement
            /// </summary>
            public ModelBiasBaselineConfig ModelBiasBaselineConfig { get; set; }

            /// <summary>
            /// ModelBiasAppSpecification
            /// Configures the model bias job to run a specified Docker container image.
            /// Required: Yes
            /// Type: ModelBiasAppSpecification
            /// Update requires: Replacement
            /// </summary>
            public ModelBiasAppSpecification ModelBiasAppSpecification { get; set; }

            /// <summary>
            /// ModelBiasJobInput
            /// Inputs for the model bias job.
            /// Required: Yes
            /// Type: ModelBiasJobInput
            /// Update requires: Replacement
            /// </summary>
            public ModelBiasJobInput ModelBiasJobInput { get; set; }

            /// <summary>
            /// ModelBiasJobOutputConfig
            /// The output configuration for monitoring jobs.
            /// Required: Yes
            /// Type: MonitoringOutputConfig
            /// Update requires: Replacement
            /// </summary>
            public MonitoringOutputConfig ModelBiasJobOutputConfig { get; set; }

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
            /// Networking options for a model bias job.
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
            /// A time limit for how long the monitoring job is allowed to run before stopping.
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

        public string Type { get; } = "AWS::SageMaker::ModelBiasJobDefinition";

        public ModelBiasJobDefinitionProperties Properties { get; } = new ModelBiasJobDefinitionProperties();

    }

    public static class ModelBiasJobDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> JobDefinitionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("JobDefinitionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
