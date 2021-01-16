using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html
    /// </summary>
    public class ScalingPlanResource : ResourceBase
    {
        public class ScalingPlanProperties
        {
            /// <summary>
            /// ApplicationSource
            /// A CloudFormation stack or a set of tags. You can create one scaling plan per application source. The
            /// ApplicationSource property must be present to ensure interoperability with the AWS Auto Scaling
            /// console.
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
