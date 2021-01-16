using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate CpuOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-cpuoptions.html
    /// </summary>
    public class CpuOptions
    {

        /// <summary>
        /// ThreadsPerCore
        /// 		
        /// The number of threads per CPU core. To disable multithreading 			for the instance, specify a value
        /// of 1. Otherwise, specify the default value of 2.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThreadsPerCore")]
        public Union<int, IntrinsicFunction> ThreadsPerCore { get; set; }

        /// <summary>
        /// CoreCount
        /// 		
        /// The number of CPU cores for the instance.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CoreCount")]
        public Union<int, IntrinsicFunction> CoreCount { get; set; }

    }
}
