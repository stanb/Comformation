using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig SimpleScalingPolicyConfiguration
    /// SimpleScalingPolicyConfiguration specifies an automatic scaling configuration that describes how the policy
    /// adds or removes instances, the cooldown period, and the number of EC2 instances that are added when the
    /// CloudWatch metric alarm condition is met. SimpleScalingPolicyConfiguration is a subproperty of the Amazon EMR
    /// InstanceGroupConfig ScalingAction property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html
    /// </summary>
    public class SimpleScalingPolicyConfiguration
    {

        /// <summary>
        /// AdjustmentType
        /// The way in which EC2 instances are added (if ScalingAdjustment is a positive number) or terminated
        /// (if ScalingAdjustment is a negative number) when the scaling activity is triggered.
        /// CHANGE_IN_CAPACITY is the default value.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

        /// <summary>
        /// CoolDown
        /// The amount of time, in seconds, after a scaling activity completes before any further
        /// trigger-related scaling activities can start. The default value is 0.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("CoolDown")]
        public Union<int, IntrinsicFunction> CoolDown { get; set; }

        /// <summary>
        /// ScalingAdjustment
        /// The amount by which to scale the instance group, based on the specified AdjustmentType. A positive
        /// value adds to the instance group's EC2 instance count. A negative number removes instances. If
        /// AdjustmentType is set to EXACT_CAPACITY, specify only a positive integer. If AdjustmentType is set
        /// to PERCENT_CHANGE_IN_CAPACITY, express the value of the percentage as a decimal. For example, -0. 20
        /// indicates a decrease in 20% increments of cluster capacity.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ScalingAdjustment")]
        public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

    }
}
