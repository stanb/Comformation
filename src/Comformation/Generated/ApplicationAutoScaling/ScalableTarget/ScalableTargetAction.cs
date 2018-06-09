using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// Application Auto Scaling ScalableTarget ScalableTargetAction
    /// The ScalableTargetAction property type specifies the minimum and maximum capacity of a scheduled action for an
    /// Application Auto Scaling scalable target.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scalabletargetaction.html
    /// </summary>
    public class ScalableTargetAction
    {

        /// <summary>
        /// MaxCapacity
        /// The maximum capacity.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        /// MinCapacity
        /// The minimum capacity.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

    }
}
