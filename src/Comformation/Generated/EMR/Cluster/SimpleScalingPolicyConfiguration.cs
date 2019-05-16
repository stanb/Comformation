using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster SimpleScalingPolicyConfiguration
    /// SimpleScalingPolicyConfiguration is a subproperty of the ScalingAction property type.
    /// SimpleScalingPolicyConfiguration determines how an automatic scaling action adds or removes instances, the
    /// cooldown period, and the number of EC2 instances that are added each time the CloudWatch metric alarm
    /// condition is satisfied.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html
    /// </summary>
    public class SimpleScalingPolicyConfiguration
    {

        /// <summary>
        /// AdjustmentType
        /// The way in which EC2 instances are added (if ScalingAdjustment is a positive number) or terminated
        /// (if ScalingAdjustment is a negative number) each time the scaling activity is triggered.
        /// CHANGE_IN_CAPACITY is the default. CHANGE_IN_CAPACITY indicates that the EC2 instance count
        /// increments or decrements by ScalingAdjustment, which should be expressed as an integer.
        /// PERCENT_CHANGE_IN_CAPACITY indicates the instance count increments or decrements by the percentage
        /// specified by ScalingAdjustment, which should be expressed as an integer. For example, 20 indicates
        /// an increase in 20% increments of cluster capacity. EXACT_CAPACITY indicates the scaling activity
        /// results in an instance group with the number of EC2 instances specified by ScalingAdjustment, which
        /// should be expressed as a positive integer.
        /// Required: No
        /// Type: String
        /// Allowed Values: CHANGE_IN_CAPACITY | EXACT_CAPACITY | PERCENT_CHANGE_IN_CAPACITY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public Union<string, IntrinsicFunction> AdjustmentType { get; set; }

        /// <summary>
        /// CoolDown
        /// The amount of time, in seconds, after a scaling activity completes before any further
        /// trigger-related scaling activities can start. The default value is 0.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CoolDown")]
        public Union<int, IntrinsicFunction> CoolDown { get; set; }

        /// <summary>
        /// ScalingAdjustment
        /// The amount by which to scale in or scale out, based on the specified AdjustmentType. A positive
        /// value adds to the instance group&#39;s EC2 instance count while a negative number removes instances. If
        /// AdjustmentType is set to EXACT_CAPACITY, the number should only be a positive integer. If
        /// AdjustmentType is set to PERCENT_CHANGE_IN_CAPACITY, the value should express the percentage as an
        /// integer. For example, -20 indicates a decrease in 20% increments of cluster capacity.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalingAdjustment")]
        public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

    }
}
