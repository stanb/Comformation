using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DataQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::DataQualityJobDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html
    /// </summary>
    public class DataQualityJobDefinitionResource : ResourceBase
    {
        public class DataQualityJobDefinitionProperties
        {
            /// <summary>
            /// JobDefinitionName
            /// The name for the monitoring job definition.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobDefinitionName { get; set; }

            /// <summary>
            /// DataQualityBaselineConfig
            /// Configures the constraints and baselines for the monitoring job.
            /// Required: No
            /// Type: DataQualityBaselineConfig
            /// Update requires: Replacement
            /// </summary>
            public DataQualityBaselineConfig DataQualityBaselineConfig { get; set; }

            /// <summary>
            /// DataQualityAppSpecification
            /// Specifies the container that runs the monitoring job.
            /// Required: Yes
            /// Type: DataQualityAppSpecification
            /// Update requires: Replacement
            /// </summary>
            public DataQualityAppSpecification DataQualityAppSpecification { get; set; }

            /// <summary>
            /// DataQualityJobInput
            /// A list of inputs for the monitoring job. Currently endpoints are supported as monitoring inputs.
            /// Required: Yes
            /// Type: DataQualityJobInput
            /// Update requires: Replacement
            /// </summary>
            public DataQualityJobInput DataQualityJobInput { get; set; }

            /// <summary>
            /// DataQualityJobOutputConfig
            /// The output configuration for monitoring jobs.
            /// Required: Yes
            /// Type: MonitoringOutputConfig
            /// Update requires: Replacement
            /// </summary>
            public MonitoringOutputConfig DataQualityJobOutputConfig { get; set; }

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
            /// Specifies networking configuration for the monitoring job.
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

        public string Type { get; } = "AWS::SageMaker::DataQualityJobDefinition";

        public DataQualityJobDefinitionProperties Properties { get; } = new DataQualityJobDefinitionProperties();

    }

    public static class DataQualityJobDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> JobDefinitionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("JobDefinitionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
    }
}
