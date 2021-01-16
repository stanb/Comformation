using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate CapacityReservationTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationtarget.html
    /// </summary>
    public class CapacityReservationTarget
    {

        /// <summary>
        /// CapacityReservationResourceGroupArn
        /// 		
        /// The ARN of the Capacity Reservation resource group in which to run the instance.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityReservationResourceGroupArn")]
        public Union<string, IntrinsicFunction> CapacityReservationResourceGroupArn { get; set; }

        /// <summary>
        /// CapacityReservationId
        /// 		
        /// The ID of the Capacity Reservation in which to run the instance.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CapacityReservationId")]
        public Union<string, IntrinsicFunction> CapacityReservationId { get; set; }

    }
}
