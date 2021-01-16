using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate LaunchTemplateElasticInferenceAccelerator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplateelasticinferenceaccelerator.html
    /// </summary>
    public class LaunchTemplateElasticInferenceAccelerator
    {

        /// <summary>
        /// Type
        /// The type of elastic inference accelerator. The possible values are eia1. medium, eia1. large, and
        /// eia1. xlarge.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Count
        /// 	
        /// 		The number of elastic inference accelerators to attach to the instance. 	
        /// 	
        /// Default: 1
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

    }
}
