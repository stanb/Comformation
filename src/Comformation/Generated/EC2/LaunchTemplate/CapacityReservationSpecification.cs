using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate CapacityReservationSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-capacityreservationspecification.html
    /// </summary>
    public class CapacityReservationSpecification
    {

        /// <summary>
        /// CapacityReservationPreference
        /// 		
        /// Indicates the instance&#39;s Capacity Reservation preferences. Possible preferences include:
        /// 		
        /// 			 			 		 open - The instance can run in any open Capacity Reservation that has matching attributes
        /// 				(instance type, platform, Availability Zone). none - The instance avoids running in a Capacity
        /// Reservation even if one is available. The instance 				runs in On-Demand capacity.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: none | open
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityReservationPreference")]
        public Union<string, IntrinsicFunction> CapacityReservationPreference { get; set; }

        /// <summary>
        /// CapacityReservationTarget
        /// 		
        /// Information about the target Capacity Reservation or Capacity Reservation group.
        /// 	
        /// Required: No
        /// Type: CapacityReservationTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityReservationTarget")]
        public CapacityReservationTarget CapacityReservationTarget { get; set; }

    }
}
