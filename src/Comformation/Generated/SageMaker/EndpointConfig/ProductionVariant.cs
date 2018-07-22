using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// Amazon SageMaker EndpointConfig ProductionVariant
    /// The ProductionVariant property type specifies a model that you want to host and the resources to deploy for
    /// hosting it. If you are deploying multiple models, tell Amazon SageMaker how to distribute traffic among the
    /// models by specifying variant weights.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html
    /// </summary>
    public class ProductionVariant
    {

        /// <summary>
        /// ModelName
        /// The name of the model that you want to host.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ModelName")]
        public Union<string, IntrinsicFunction> ModelName { get; set; }

        /// <summary>
        /// VariantName
        /// The name of the production variant.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VariantName")]
        public Union<string, IntrinsicFunction> VariantName { get; set; }

        /// <summary>
        /// InitialInstanceCount
        /// The number of instances to launch initially for this production variant.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitialInstanceCount")]
        public Union<int, IntrinsicFunction> InitialInstanceCount { get; set; }

        /// <summary>
        /// InstanceType
        /// The ML compute instance type to use for this production variant.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// InitialVariantWeight
        /// Determines initial traffic distribution among all of the models that you specify in the endpoint
        /// configuration. The traffic to a production variant is determined by the ratio of the VariantWeight
        /// to the sum of all VariantWeight values across all production variants for an endpoint. If
        /// unspecified, it defaults to 1. 0.
        /// Required: Yes
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitialVariantWeight")]
        public Union<double, IntrinsicFunction> InitialVariantWeight { get; set; }

    }
}
