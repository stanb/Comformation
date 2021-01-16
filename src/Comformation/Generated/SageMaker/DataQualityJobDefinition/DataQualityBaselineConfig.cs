using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DataQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::DataQualityJobDefinition DataQualityBaselineConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig.html
    /// </summary>
    public class DataQualityBaselineConfig
    {

        /// <summary>
        /// BaseliningJobName
        /// The name of the job that performs baselining for the data quality monitoring job.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BaseliningJobName")]
        public Union<string, IntrinsicFunction> BaseliningJobName { get; set; }

        /// <summary>
        /// ConstraintsResource
        /// The constraints resource for a monitoring job.
        /// Required: No
        /// Type: ConstraintsResource
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConstraintsResource")]
        public ConstraintsResource ConstraintsResource { get; set; }

        /// <summary>
        /// StatisticsResource
        /// Configuration for monitoring constraints and monitoring statistics. These baseline resources are
        /// compared against the results of the current job from the series of jobs scheduled to collect data
        /// periodically.
        /// Required: No
        /// Type: StatisticsResource
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StatisticsResource")]
        public StatisticsResource StatisticsResource { get; set; }

    }
}
