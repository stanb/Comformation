using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate CapacityReservationTarget
    /// Specifies a target Capacity Reservation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationtarget.html
    /// </summary>
    public class CapacityReservationTarget
    {

        /// <summary>
        /// CapacityReservationId
        /// 		
        /// The ID of the Capacity Reservation.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityReservationId")]
        public Union<string, IntrinsicFunction> CapacityReservationId { get; set; }

    }
}
