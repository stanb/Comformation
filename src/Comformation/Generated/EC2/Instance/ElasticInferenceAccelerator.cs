using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// Amazon Elastic Compute Cloud Instance ElasticInferenceAccelerator
    /// The ElasticInferenceAccelerator property type specifies an elastic inference accelerator for an instance.
    /// Elastic Inference (EI) accelerators are a resource you can attach to your Amazon EC2 instances to accelerate
    /// your Deep Learning (DL) inference workloads.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticInferenceaccelerator.html
    /// </summary>
    public class ElasticInferenceAccelerator
    {

        /// <summary>
        /// Type
        /// The type of elastic inference accelerator. The possible values are eia1. medium, eia1. large, and
        /// eia1. xlarge.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
