using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameServerGroup
{
    /// <summary>
    /// AWS::GameLift::GameServerGroup InstanceDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-instancedefinition.html
    /// </summary>
    public class InstanceDefinition
    {

        /// <summary>
        /// InstanceType
        /// An Amazon EC2 instance type designation.
        /// Required: Yes
        /// Type: String
        /// Allowed values: c4. 2xlarge | c4. 4xlarge | c4. 8xlarge | c4. large | c4. xlarge | c5. 12xlarge |
        /// c5. 18xlarge | c5. 24xlarge | c5. 2xlarge | c5. 4xlarge | c5. 9xlarge | c5. large | c5. xlarge |
        /// c5a. 12xlarge | c5a. 16xlarge | c5a. 24xlarge | c5a. 2xlarge | c5a. 4xlarge | c5a. 8xlarge | c5a.
        /// large | c5a. xlarge | m4. 10xlarge | m4. 2xlarge | m4. 4xlarge | m4. large | m4. xlarge | m5.
        /// 12xlarge | m5. 16xlarge | m5. 24xlarge | m5. 2xlarge | m5. 4xlarge | m5. 8xlarge | m5. large | m5.
        /// xlarge | m5a. 12xlarge | m5a. 16xlarge | m5a. 24xlarge | m5a. 2xlarge | m5a. 4xlarge | m5a. 8xlarge
        /// | m5a. large | m5a. xlarge | r4. 16xlarge | r4. 2xlarge | r4. 4xlarge | r4. 8xlarge | r4. large |
        /// r4. xlarge | r5. 12xlarge | r5. 16xlarge | r5. 24xlarge | r5. 2xlarge | r5. 4xlarge | r5. 8xlarge |
        /// r5. large | r5. xlarge | r5a. 12xlarge | r5a. 16xlarge | r5a. 24xlarge | r5a. 2xlarge | r5a. 4xlarge
        /// | r5a. 8xlarge | r5a. large | r5a. xlarge
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// Instance weighting that indicates how much this instance type contributes to the total capacity of a
        /// game server group. Instance weights are used by GameLift FleetIQ to calculate the instance type&#39;s
        /// cost per unit hour and better identify the most cost-effective options. For detailed information on
        /// weighting instance capacity, see Instance Weighting in the Amazon Elastic Compute Cloud Auto Scaling
        /// User Guide. Default value is &quot;1&quot;.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 3
        /// Pattern: ^[\u0031-\u0039][\u0030-\u0039]{0,2}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<string, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
