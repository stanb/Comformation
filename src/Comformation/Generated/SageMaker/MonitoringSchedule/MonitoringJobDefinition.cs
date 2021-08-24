using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule MonitoringJobDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html
    /// </summary>
    public class MonitoringJobDefinition
    {

        /// <summary>
        /// BaselineConfig
        /// Baseline configuration used to validate that the data conforms to the specified constraints and
        /// statistics
        /// Required: No
        /// Type: BaselineConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaselineConfig")]
        public BaselineConfig BaselineConfig { get; set; }

        /// <summary>
        /// MonitoringAppSpecification
        /// Configures the monitoring job to run a specified Docker container image.
        /// Required: Yes
        /// Type: MonitoringAppSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringAppSpecification")]
        public MonitoringAppSpecification MonitoringAppSpecification { get; set; }

        /// <summary>
        /// MonitoringInputs
        /// The array of inputs for the monitoring job. Currently we support monitoring an Amazon SageMaker
        /// Endpoint.
        /// Required: Yes
        /// Type: List of MonitoringInput
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringInputs")]
        public List<MonitoringInput> MonitoringInputs { get; set; }

        /// <summary>
        /// MonitoringOutputConfig
        /// The array of outputs from the monitoring job to be uploaded to Amazon Simple Storage Service (Amazon
        /// S3).
        /// Required: Yes
        /// Type: MonitoringOutputConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringOutputConfig")]
        public MonitoringOutputConfig MonitoringOutputConfig { get; set; }

        /// <summary>
        /// MonitoringResources
        /// Identifies the resources, ML compute instances, and ML storage volumes to deploy for a monitoring
        /// job. In distributed processing, you specify more than one instance.
        /// Required: Yes
        /// Type: MonitoringResources
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringResources")]
        public MonitoringResources MonitoringResources { get; set; }

        /// <summary>
        /// NetworkConfig
        /// Specifies networking options for an monitoring job.
        /// Required: No
        /// Type: NetworkConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkConfig")]
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on
        /// your behalf.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// StoppingCondition
        /// Specifies a time limit for how long the monitoring job is allowed to run.
        /// Required: No
        /// Type: StoppingCondition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StoppingCondition")]
        public StoppingCondition StoppingCondition { get; set; }

    }
}
