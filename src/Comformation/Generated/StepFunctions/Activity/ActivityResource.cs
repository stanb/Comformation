using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.Activity
{
    /// <summary>
    /// AWS::StepFunctions::Activity
    /// Use the AWS::StepFunctions::Activity resource to create an AWS Step Functions activity.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html
    /// </summary>
    public class ActivityResource : ResourceBase
    {
        public class ActivityProperties
        {
            /// <summary>
            /// Name
            /// The name of the activity to create. This name must be unique for your AWS account and region.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::StepFunctions::Activity";

        public ActivityProperties Properties { get; } = new ActivityProperties();

    }

	public static class ActivityAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
