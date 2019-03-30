using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationtarget.html
    /// </summary>
    public class CapacityReservationTarget
    {

        /// <summary>
        /// CapacityReservationId
        /// </summary>
        [JsonProperty("CapacityReservationId")]
        public Union<string, IntrinsicFunction> CapacityReservationId { get; set; }

    }
}
