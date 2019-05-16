using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan
    /// The AWS::AutoScalingPlans::ScalingPlan resource defines a scaling plan that AWS Auto Scaling uses to scale the
    /// following application resources:
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
            /// Type: ApplicationSource
            /// Update requires: No interruption
            /// </summary>
			public ApplicationSource ApplicationSource { get; set; }

            /// <summary>
            /// ScalingInstructions
            /// The scaling instructions.
            /// Required: Yes
            /// Type: List of ScalingInstruction
            /// Update requires: No interruption
            /// </summary>
			public List<ScalingInstruction> ScalingInstructions { get; set; }

        }

        public string Type { get; } = "AWS::AutoScalingPlans::ScalingPlan";

        public ScalingPlanProperties Properties { get; } = new ScalingPlanProperties();

    }

	public static class ScalingPlanAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ScalingPlanName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ScalingPlanName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ScalingPlanVersion = new ResourceAttribute<Union<string, IntrinsicFunction>>("ScalingPlanVersion");
	}
}
