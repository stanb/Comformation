using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition ModelBiasBaselineConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasbaselineconfig.html
    /// </summary>
    public class ModelBiasBaselineConfig
    {

        /// <summary>
        /// BaseliningJobName
        /// The name of the baseline model bias job.
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

    }
}
