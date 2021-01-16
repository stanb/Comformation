using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelQualityJobDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html
    /// </summary>
    public class ModelQualityJobDefinitionResource : ResourceBase
    {
        public class ModelQualityJobDefinitionProperties
        {
            /// <summary>
            /// JobDefinitionName
            /// The name of the monitoring job definition.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobDefinitionName { get; set; }

            /// <summary>
            /// ModelQualityBaselineConfig
            /// Specifies the constraints and baselines for the monitoring job.
            /// Required: No
            /// Type: ModelQualityBaselineConfig
            /// Update requires: Replacement
            /// </summary>
            public ModelQualityBaselineConfig ModelQualityBaselineConfig { get; set; }

            /// <summary>
            /// ModelQualityAppSpecification
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: ModelQualityAppSpecification
            /// Update requires: Replacement
            /// </summary>
            public ModelQualityAppSpecification ModelQualityAppSpecification { get; set; }

            /// <summary>
            /// ModelQualityJobInput
            /// A list of the inputs that are monitored. Currently endpoints are supported.
            /// Required: Yes
            /// Type: ModelQualityJobInput
            /// Update requires: Replacement
            /// </summary>
            public ModelQualityJobInput ModelQualityJobInput { get; set; }

            /// <summary>
            /// ModelQualityJobOutputConfig
            /// The output configuration for monitoring jobs.
            /// Required: Yes
            /// Type: MonitoringOutputConfig
            /// Update requires: Replacement
            /// </summary>
            public MonitoringOutputConfig ModelQualityJobOutputConfig { get; set; }

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
            /// Specifies the network configuration for the monitoring job.
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

        public string Type { get; } = "AWS::SageMaker::ModelQualityJobDefinition";

        public ModelQualityJobDefinitionProperties Properties { get; } = new ModelQualityJobDefinitionProperties();

    }

    public static class ModelQualityJobDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> JobDefinitionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("JobDefinitionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
