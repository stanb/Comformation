using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster SimpleScalingPolicyConfiguration
    /// SimpleScalingPolicyConfiguration is a subproperty of the Amazon EMR Cluster ScalingAction property. It
    /// specifies an automatic scaling configuration that describes how the policy adds or removes instances, the
    /// cooldown period, and the number of Amazon EC2 instances that will be added each time the CloudWatch metric
    /// alarm condition is satisfied.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html
    /// </summary>
    public class SimpleScalingPolicyConfiguration
    {

        /// <summary>
        /// AdjustmentType
        /// The way in which Amazon EC2 instances are added (if ScalingAdjustment is a positive number) or
        /// terminated (if ScalingAdjustment is a negative number) each time the scaling activity is triggered.
        /// CHANGE_IN_CAPACITY is the default.
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
        /// The amount by which to scale in or scale out, based on the specified AdjustmentType. A positive
        /// value adds to the instance group's Amazon EC2 instance count while a negative number removes
        /// instances. If AdjustmentType is set to EXACT_CAPACITY, the number should only be a positive integer.
        /// If AdjustmentType is set to PERCENT_CHANGE_IN_CAPACITY, the value should express the percentage as a
        /// decimal.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ScalingAdjustment")]
        public Union<int, IntrinsicFunction> ScalingAdjustment { get; set; }

    }
}
