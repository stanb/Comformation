using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTarget
{
    /// <summary>
    /// AWS::Inspector::AssessmentTarget
    /// The AWS::Inspector::AssessmentTarget resource is used to create Amazon Inspector assessment targets, which
    /// specify the Amazon EC2 instances that will be analyzed during an assessment run.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html
    /// </summary>
    public class AssessmentTargetResource : ResourceBase
    {
        public class AssessmentTargetProperties
        {
            /// <summary>
            /// AssessmentTargetName
            /// The name of the Amazon Inspector assessment target. The name must be unique within the AWS account.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTargetName { get; set; }

            /// <summary>
            /// ResourceGroupArn
            /// The ARN that specifies the resource group that is used to create the assessment target. If
            /// resourceGroupArn is not specified, all EC2 instances in the current AWS account and Region are
            /// included in the assessment target.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
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
