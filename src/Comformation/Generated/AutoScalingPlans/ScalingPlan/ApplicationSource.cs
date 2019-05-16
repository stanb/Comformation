using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan ApplicationSource
    /// ApplicationSource is a property of ScalingPlan that specifies the application source to use with AWS Auto
    /// Scaling. You can create one scaling plan per application source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-applicationsource.html
    /// </summary>
    public class ApplicationSource
    {

        /// <summary>
        /// CloudFormationStackARN
        /// The Amazon Resource Name (ARN) of a CloudFormation stack.
        /// Required: No
        /// Type: String
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudFormationStackARN")]
        public Union<string, IntrinsicFunction> CloudFormationStackARN { get; set; }

        /// <summary>
        /// TagFilters
        /// A set of tags (up to 50).
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

    }
}
