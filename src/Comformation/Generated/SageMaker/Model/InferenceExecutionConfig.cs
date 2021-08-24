using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model InferenceExecutionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-inferenceexecutionconfig.html
    /// </summary>
    public class InferenceExecutionConfig
    {

        /// <summary>
        /// Mode
        /// How containers in a multi-container are run. The following values are valid.
        /// Serial - Containers run as a serial pipeline. Direct - Only the individual container that you
        /// specify is run.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Mode")]
        public Union<string, IntrinsicFunction> Mode { get; set; }

    }
}
