using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance EnclaveOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-enclaveoptions.html
    /// </summary>
    public class EnclaveOptions
    {

        /// <summary>
        /// Enabled
        /// If this parameter is set to true, the instance is enabled for AWS Nitro Enclaves; otherwise, it is
        /// not enabled for AWS Nitro Enclaves.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
