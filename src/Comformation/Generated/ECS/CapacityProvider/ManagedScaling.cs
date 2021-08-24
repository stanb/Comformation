using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.CapacityProvider
{
    /// <summary>
    /// AWS::ECS::CapacityProvider ManagedScaling
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedscaling.html
    /// </summary>
    public class ManagedScaling
    {

        /// <summary>
        /// MinimumScalingStepSize
        /// 		
        /// The minimum number of container instances that Amazon ECS will scale in or scale out at one 			time.
        /// If this parameter is omitted, the default value of 1 is used.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 10000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinimumScalingStepSize")]
        public Union<int, IntrinsicFunction> MinimumScalingStepSize { get; set; }

        /// <summary>
        /// MaximumScalingStepSize
        /// 		
        /// The maximum number of container instances that Amazon ECS will scale in or scale out at one 			time.
        /// If this parameter is omitted, the default value of 10000 is 			used.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 10000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumScalingStepSize")]
        public Union<int, IntrinsicFunction> MaximumScalingStepSize { get; set; }

        /// <summary>
        /// Status
        /// 		
        /// Whether or not to enable managed scaling for the capacity provider.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// TargetCapacity
        /// 		
        /// The target capacity value for the capacity provider. The specified value must be 			greater than 0
        /// and less than or equal to 100. A value of 				100 will result in the Amazon EC2 instances in your
        /// Auto Scaling group being 			completely utilized.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetCapacity")]
        public Union<int, IntrinsicFunction> TargetCapacity { get; set; }

        /// <summary>
        /// InstanceWarmupPeriod
        /// 		
        /// The period of time, in seconds, after a newly launched Amazon EC2 instance can contribute 			to
        /// CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value 			of 300
        /// seconds is used.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 10000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceWarmupPeriod")]
        public Union<int, IntrinsicFunction> InstanceWarmupPeriod { get; set; }

    }
}
