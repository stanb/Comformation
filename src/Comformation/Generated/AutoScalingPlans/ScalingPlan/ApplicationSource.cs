using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan ApplicationSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-applicationsource.html
    /// </summary>
    public class ApplicationSource
    {

        /// <summary>
        /// CloudFormationStackARN
        /// The Amazon Resource Name (ARN) of a CloudFormation stack.
        /// You must specify either a CloudFormationStackARN or TagFilters.
        /// Required: No
        /// Type: String
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudFormationStackARN")]
        public Union<string, IntrinsicFunction> CloudFormationStackARN { get; set; }

        /// <summary>
        /// TagFilters
        /// A set of tag filters (keys and values). Each tag filter specified must contain a key with values as
        /// optional. Each scaling plan can include up to 50 keys, and each key can include up to 20 values.
        /// Tags are part of the syntax that you use to specify the resources you want returned when configuring
        /// a scaling plan from the AWS Auto Scaling console. You do not need to specify valid tag filter values
        /// when you create a scaling plan with AWS CloudFormation. The Key and Values properties can accept any
        /// value as long as the combination of values is unique across scaling plans. However, if you also want
        /// to use the AWS Auto Scaling console to edit the scaling plan, then you must specify valid values.
        /// You must specify either a CloudFormationStackARN or TagFilters.
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

    }
}
