using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan
    /// Creates a scaling plan for AWS Auto Scaling. For more information, see the AWS Auto Scaling User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html
    /// </summary>
    public class ScalingPlanResource : ResourceBase
    {
        public class ScalingPlanProperties
        {
            /// <summary>
            /// ApplicationSource
            /// A CloudFormation stack or a set of tags. You can create one scaling plan per application source.
            /// Required: Yes
            /// Type: AWS Auto Scaling ScalingPlan ApplicationSource
            /// Update requires: No interruption
            /// </summary>
			public ApplicationSource ApplicationSource { get; set; }

            /// <summary>
            /// ScalingInstructions
            /// The scaling instructions.
            /// Required: Yes
            /// Type: List of AWS Auto Scaling ScalingPlan ScalingInstruction property types
            /// Update requires: No interruption
            /// </summary>
			public List<ScalingInstruction> ScalingInstructions { get; set; }

        }
    
        public string Type { get; } = "AWS::AutoScalingPlans::ScalingPlan";
        
        public ScalingPlanProperties Properties { get; } = new ScalingPlanProperties();

    }
}
