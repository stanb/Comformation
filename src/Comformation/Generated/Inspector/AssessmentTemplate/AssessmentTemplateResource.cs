using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTemplate
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html
    /// </summary>
    public class AssessmentTemplateResource : ResourceBase
    {
        public class AssessmentTemplateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-assessmenttargetarn
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTargetArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-durationinseconds
            /// </summary>
			public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-assessmenttemplatename
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTemplateName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-rulespackagearns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> RulesPackageArns { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-userattributesforfindings
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> UserAttributesForFindings { get; set; }

        }
    
        public string Type { get; } = "AWS::Inspector::AssessmentTemplate";
        
        public AssessmentTemplateProperties Properties { get; } = new AssessmentTemplateProperties();
    }

	public static class AssessmentTemplateAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
