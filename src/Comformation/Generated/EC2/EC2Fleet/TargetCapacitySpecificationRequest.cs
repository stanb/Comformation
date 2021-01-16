using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet TargetCapacitySpecificationRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-targetcapacityspecificationrequest.html
    /// </summary>
    public class TargetCapacitySpecificationRequest
    {

        /// <summary>
        /// DefaultTargetCapacityType
        /// The default TotalTargetCapacity, which is either Spot or On-Demand.
        /// Required: No
        /// Type: String
        /// Allowed values: on-demand | spot
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultTargetCapacityType")]
        public Union<string, IntrinsicFunction> DefaultTargetCapacityType { get; set; }

        /// <summary>
        /// TotalTargetCapacity
        /// The number of units to request, filled using DefaultTargetCapacityType.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TotalTargetCapacity")]
        public Union<int, IntrinsicFunction> TotalTargetCapacity { get; set; }

        /// <summary>
        /// OnDemandTargetCapacity
        /// The number of On-Demand units to request.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnDemandTargetCapacity")]
        public Union<int, IntrinsicFunction> OnDemandTargetCapacity { get; set; }

        /// <summary>
        /// SpotTargetCapacity
        /// The number of Spot units to request.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotTargetCapacity")]
        public Union<int, IntrinsicFunction> SpotTargetCapacity { get; set; }

    }
}
