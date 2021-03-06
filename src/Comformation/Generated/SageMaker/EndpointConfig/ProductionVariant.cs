using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig ProductionVariant
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html
    /// </summary>
    public class ProductionVariant
    {

        /// <summary>
        /// ModelName
        /// The name of the model that you want to host. This is the name that you specified when creating the
        /// model.
        /// Required: Yes
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ModelName")]
        public Union<string, IntrinsicFunction> ModelName { get; set; }

        /// <summary>
        /// VariantName
        /// The name of the production variant.
        /// Required: Yes
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VariantName")]
        public Union<string, IntrinsicFunction> VariantName { get; set; }

        /// <summary>
        /// InitialInstanceCount
        /// Number of instances to launch initially.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitialInstanceCount")]
        public Union<int, IntrinsicFunction> InitialInstanceCount { get; set; }

        /// <summary>
        /// InstanceType
        /// The ML compute instance type.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ml. c4. 2xlarge | ml. c4. 4xlarge | ml. c4. 8xlarge | ml. c4. large | ml. c4. xlarge
        /// | ml. c5. 18xlarge | ml. c5. 2xlarge | ml. c5. 4xlarge | ml. c5. 9xlarge | ml. c5. large | ml. c5.
        /// xlarge | ml. c5d. 18xlarge | ml. c5d. 2xlarge | ml. c5d. 4xlarge | ml. c5d. 9xlarge | ml. c5d. large
        /// | ml. c5d. xlarge | ml. g4dn. 12xlarge | ml. g4dn. 16xlarge | ml. g4dn. 2xlarge | ml. g4dn. 4xlarge
        /// | ml. g4dn. 8xlarge | ml. g4dn. xlarge | ml. inf1. 24xlarge | ml. inf1. 2xlarge | ml. inf1. 6xlarge
        /// | ml. inf1. xlarge | ml. m4. 10xlarge | ml. m4. 16xlarge | ml. m4. 2xlarge | ml. m4. 4xlarge | ml.
        /// m4. xlarge | ml. m5. 12xlarge | ml. m5. 24xlarge | ml. m5. 2xlarge | ml. m5. 4xlarge | ml. m5. large
        /// | ml. m5. xlarge | ml. m5d. 12xlarge | ml. m5d. 24xlarge | ml. m5d. 2xlarge | ml. m5d. 4xlarge | ml.
        /// m5d. large | ml. m5d. xlarge | ml. p2. 16xlarge | ml. p2. 8xlarge | ml. p2. xlarge | ml. p3.
        /// 16xlarge | ml. p3. 2xlarge | ml. p3. 8xlarge | ml. r5. 12xlarge | ml. r5. 24xlarge | ml. r5. 2xlarge
        /// | ml. r5. 4xlarge | ml. r5. large | ml. r5. xlarge | ml. r5d. 12xlarge | ml. r5d. 24xlarge | ml.
        /// r5d. 2xlarge | ml. r5d. 4xlarge | ml. r5d. large | ml. r5d. xlarge | ml. t2. 2xlarge | ml. t2. large
        /// | ml. t2. medium | ml. t2. xlarge
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// AcceleratorType
        /// The size of the Elastic Inference (EI) instance to use for the production variant. EI instances
        /// provide on-demand GPU computing for inference. For more information, see Using Elastic Inference in
        /// Amazon SageMaker. For more information, see Using Elastic Inference in Amazon SageMaker.
        /// Required: No
        /// Type: String
        /// Allowed values: ml. eia1. large | ml. eia1. medium | ml. eia1. xlarge | ml. eia2. large | ml. eia2.
        /// medium | ml. eia2. xlarge
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AcceleratorType")]
        public Union<string, IntrinsicFunction> AcceleratorType { get; set; }

        /// <summary>
        /// InitialVariantWeight
        /// Determines initial traffic distribution among all of the models that you specify in the endpoint
        /// configuration. The traffic to a production variant is determined by the ratio of the VariantWeight
        /// to the sum of all VariantWeight values across all ProductionVariants. If unspecified, it defaults to
        /// 1. 0.
        /// Required: Yes
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitialVariantWeight")]
        public Union<double, IntrinsicFunction> InitialVariantWeight { get; set; }

    }
}
