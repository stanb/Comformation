using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelExplainabilityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelExplainabilityJobDefinition ModelExplainabilityBaselineConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilitybaselineconfig.html
    /// </summary>
    public class ModelExplainabilityBaselineConfig
    {

        /// <summary>
        /// BaseliningJobName
        /// The name of the baseline model explainability job.
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
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ConstraintsResource
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConstraintsResource")]
        public ConstraintsResource ConstraintsResource { get; set; }

    }
}
