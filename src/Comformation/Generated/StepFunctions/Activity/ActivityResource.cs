using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.Activity
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html
    /// </summary>
    public class ActivityResource : ResourceBase
    {
        public class ActivityProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html#cfn-stepfunctions-activity-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::StepFunctions::Activity";
        
        public ActivityProperties Properties { get; } = new ActivityProperties();
    }

	public static class ActivityAttributes
	{
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
