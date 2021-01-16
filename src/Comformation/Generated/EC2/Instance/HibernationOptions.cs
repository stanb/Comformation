using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::Instance HibernationOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-hibernationoptions.html
    /// </summary>
    public class HibernationOptions
    {

        /// <summary>
        /// Configured
        /// If you set this parameter to true, your instance is enabled for hibernation.
        /// Default: false
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Configured")]
        public Union<bool, IntrinsicFunction> Configured { get; set; }

    }
}
