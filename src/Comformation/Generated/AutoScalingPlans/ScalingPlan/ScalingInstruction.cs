using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan ScalingInstruction
    /// The ScalingInstruction property type specifies the scaling configuration for a scalable resource in an AWS
    /// Auto Scaling scaling plan.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html
    /// </summary>
    public class ScalingInstruction
    {

        /// <summary>
        /// ResourceId
        /// The ID of the resource. For examples, see ScalingInstruction in the AWS Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceId")]
        public Union<string, IntrinsicFunction> ResourceId { get; set; }

        /// <summary>
        /// ServiceNamespace
        /// The namespace of the AWS service. For a list of values, see ScalingInstruction in the AWS Auto
        /// Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceNamespace")]
        public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

        /// <summary>
        /// ScalableDimension
        /// The scalable dimension associated with the resource. For a list of values, see ScalingInstruction in
        /// the AWS Auto Scaling API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScalableDimension")]
        public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

        /// <summary>
        /// MinCapacity
        /// The minimum value to scale to in response to a scale out event.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

        /// <summary>
        /// TargetTrackingConfigurations
        /// The target tracking scaling policies (up to 10).
        /// Required: Yes
        /// Type: List of AWS Auto Scaling ScalingPlan TargetTrackingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTrackingConfigurations")]
        public List<TargetTrackingConfiguration> TargetTrackingConfigurations { get; set; }

        /// <summary>
        /// MaxCapacity
        /// The maximum value to scale to in response to a scale in event.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

    }
}
