using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskSet
{
    /// <summary>
    /// AWS::ECS::TaskSet Scale
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-scale.html
    /// </summary>
    public class Scale
    {

        /// <summary>
        /// Unit
        /// 		
        /// The unit of measure for the scale value.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: PERCENT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

        /// <summary>
        /// Value
        /// 		
        /// The value, specified as a percent total of a service&#39;s desiredCount, to 			scale the task set.
        /// Accepted values are numbers between 0 and 100.
        /// 	
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<double, IntrinsicFunction> Value { get; set; }

    }
}
