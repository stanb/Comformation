using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-capacityreservationspecification.html
    /// </summary>
    public class CapacityReservationSpecification
    {

        /// <summary>
        /// CapacityReservationPreference
        /// </summary>
        [JsonProperty("CapacityReservationPreference")]
        public CapacityReservationPreference CapacityReservationPreference { get; set; }

        /// <summary>
        /// CapacityReservationTarget
        /// </summary>
        [JsonProperty("CapacityReservationTarget")]
        public CapacityReservationTarget CapacityReservationTarget { get; set; }

    }
}
