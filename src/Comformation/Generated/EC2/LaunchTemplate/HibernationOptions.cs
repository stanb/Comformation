using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate HibernationOptions
    /// Specifies whether your instance is configured for hibernation. This parameter is valid 			only if the instance
    /// meets the hibernation 				prerequisites. Hibernation is currently supported only for Amazon Linux. For 			more
    /// information, see Hibernate Your Instance in the 			Amazon Elastic Compute Cloud User Guide.
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
