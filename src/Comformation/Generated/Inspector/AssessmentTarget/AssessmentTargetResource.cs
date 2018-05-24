using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTarget
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html
    /// </summary>
    public class AssessmentTargetResource : ResourceBase
    {
        public class AssessmentTargetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html#cfn-inspector-assessmenttarget-assessmenttargetname
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTargetName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttarget.html#cfn-inspector-assessmenttarget-resourcegrouparn
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceGroupArn { get; set; }

        }
    
        public string Type { get; } = "AWS::Inspector::AssessmentTarget";
        
        public AssessmentTargetProperties Properties { get; } = new AssessmentTargetProperties();
    }

	public static class AssessmentTargetAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
