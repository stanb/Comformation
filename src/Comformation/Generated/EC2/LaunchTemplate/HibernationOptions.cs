using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-hibernationoptions.html
    /// </summary>
    public class HibernationOptions
    {

        /// <summary>
        /// Configured
        /// </summary>
        [JsonProperty("Configured")]
        public Union<bool, IntrinsicFunction> Configured { get; set; }

    }
}
