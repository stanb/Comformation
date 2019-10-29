using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalableTarget SuspendedState
    /// Specifies whether the scaling activities for a scalable target are in a suspended state.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html
    /// </summary>
    public class SuspendedState
    {

        /// <summary>
        /// DynamicScalingInSuspended
        /// Whether scale in by a target tracking scaling policy or a step scaling policy is suspended. Set the
        /// value to true if you don&#39;t want Application Auto Scaling to remove capacity when a scaling policy is
        /// triggered. The default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamicScalingInSuspended")]
        public Union<bool, IntrinsicFunction> DynamicScalingInSuspended { get; set; }

        /// <summary>
        /// DynamicScalingOutSuspended
        /// Whether scale out by a target tracking scaling policy or a step scaling policy is suspended. Set the
        /// value to true if you don&#39;t want Application Auto Scaling to add capacity when a scaling policy is
        /// triggered. The default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamicScalingOutSuspended")]
        public Union<bool, IntrinsicFunction> DynamicScalingOutSuspended { get; set; }

        /// <summary>
        /// ScheduledScalingSuspended
        /// Whether scheduled scaling is suspended. Set the value to true if you don&#39;t want Application Auto
        /// Scaling to add or remove capacity by initiating scheduled actions. The default is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduledScalingSuspended")]
        public Union<bool, IntrinsicFunction> ScheduledScalingSuspended { get; set; }

    }
}
