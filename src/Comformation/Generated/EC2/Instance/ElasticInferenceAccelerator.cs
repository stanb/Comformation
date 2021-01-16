using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance ElasticInferenceAccelerator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticinferenceaccelerator.html
    /// </summary>
    public class ElasticInferenceAccelerator
    {

        /// <summary>
        /// Count
        /// The number of elastic inference accelerators to attach to the instance.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

        /// <summary>
        /// Type
        /// 	The type of elastic inference accelerator. The possible values are eia1. medium, eia1. large, eia1.
        /// xlarge, eia2. medium, eia2. large, and eia2. xlarge.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
