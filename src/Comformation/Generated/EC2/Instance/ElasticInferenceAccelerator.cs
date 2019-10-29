using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance ElasticInferenceAccelerator
    /// Specifies the Elastic Inference Accelerator for the instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticinferenceaccelerator.html
    /// </summary>
    public class ElasticInferenceAccelerator
    {

        /// <summary>
        /// Type
        /// 	The type of elastic inference accelerator. The possible values are eia1. medium, eia1. large, and
        /// eia1. xlarge.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
