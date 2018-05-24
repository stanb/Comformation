using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html
    /// </summary>
    public class ScalingPlanResource : ResourceBase
    {
        public class ScalingPlanProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html#cfn-autoscalingplans-scalingplan-applicationsource
            /// </summary>
			public Union<ApplicationSource, IntrinsicFunction> ApplicationSource { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html#cfn-autoscalingplans-scalingplan-scalinginstructions
            /// </summary>
			public Union<List<ScalingInstruction>, IntrinsicFunction> ScalingInstructions { get; set; }

        }
    
        public string Type { get; } = "AWS::AutoScalingPlans::ScalingPlan";
        
        public ScalingPlanProperties Properties { get; } = new ScalingPlanProperties();
    }
}
