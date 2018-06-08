using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan ApplicationSource
    /// The ApplicationSource property type specifies the application source for an AWS Auto Scaling scaling plan. You
    /// can create one scaling plan per application source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-applicationsource.html
    /// </summary>
    public class ApplicationSource
    {

        /// <summary>
        /// CloudFormationStackARN
        /// The Amazon Resource Name (ARN) of a CloudFormation stack.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudFormationStackARN")]
        public Union<string, IntrinsicFunction> CloudFormationStackARN { get; set; }

        /// <summary>
        /// TagFilters
        /// A set of tags (up to 50).
        /// Required: No
        /// Type: List of AWS Auto Scaling ScalingPlan TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public Union<List<TagFilter>, IntrinsicFunction> TagFilters { get; set; }

    }
}
