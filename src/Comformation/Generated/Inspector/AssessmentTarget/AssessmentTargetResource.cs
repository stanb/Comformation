using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTarget
{
    /// <summary>
    /// AWS::Inspector::AssessmentTarget
    /// The AWS::Inspector::AssessmentTarget resource creates an Amazon Inspector assessment target - a resource that
    /// contains information about an Amazon Inspector application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html
    /// </summary>
    public class AssessmentTargetResource : ResourceBase
    {
        public class AssessmentTargetProperties
        {
            /// <summary>
            /// AssessmentTargetName
            /// The name of the Amazon Inspector assessment target.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTargetName { get; set; }

            /// <summary>
            /// ResourceGroupArn
            /// The ARN that specifies the resource group that is associated with the assessment target. If
            /// unspecified, all Amazon EC2 instances in your AWS account in the current region will be included in
            /// the assessment target.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceGroupArn { get; set; }

        }

        public string Type { get; } = "AWS::Inspector::AssessmentTarget";

        public AssessmentTargetProperties Properties { get; } = new AssessmentTargetProperties();

    }

	public static class AssessmentTargetAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
