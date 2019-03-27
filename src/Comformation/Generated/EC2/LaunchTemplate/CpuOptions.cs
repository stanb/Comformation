using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-cpuoptions.html
    /// </summary>
    public class CpuOptions
    {

        /// <summary>
        /// ThreadsPerCore
        /// </summary>
        [JsonProperty("ThreadsPerCore")]
        public Union<int, IntrinsicFunction> ThreadsPerCore { get; set; }

        /// <summary>
        /// CoreCount
        /// </summary>
        [JsonProperty("CoreCount")]
        public Union<int, IntrinsicFunction> CoreCount { get; set; }

    }
}
