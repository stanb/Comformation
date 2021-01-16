using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate HibernationOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-hibernationoptions.html
    /// </summary>
    public class HibernationOptions
    {

        /// <summary>
        /// Configured
        /// If you set this parameter to true, the instance is enabled for hibernation.
        /// Default: false
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Configured")]
        public Union<bool, IntrinsicFunction> Configured { get; set; }

    }
}
