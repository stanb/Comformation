using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Model
{
    /// <summary>
    /// AWS::SageMaker::Model MultiModelConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-multimodelconfig.html
    /// </summary>
    public class MultiModelConfig
    {

        /// <summary>
        /// ModelCacheSetting
        /// Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models
        /// so that a model does not have to be loaded into memory each time it is invoked. Some use cases do
        /// not benefit from model caching. For example, if an endpoint hosts a large number of models that are
        /// each invoked infrequently, the endpoint might perform better if you disable model caching. To
        /// disable model caching, set the value of this parameter to Disabled.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ModelCacheSetting")]
        public Union<string, IntrinsicFunction> ModelCacheSetting { get; set; }

    }
}
