using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTemplate
{
    /// <summary>
    /// AWS::Inspector::AssessmentTemplate
    /// The AWS::Inspector::AssessmentTemplate resource creates an Amazon Inspector assessment template - a resource
    /// that contains information about an Amazon Inspector assessment template.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html
    /// </summary>
    public class AssessmentTemplateResource : ResourceBase
    {
        public class AssessmentTemplateProperties
        {
            /// <summary>
            /// AssessmentTargetArn
            /// The ARN of the assessment target that corresponds to this assessment template.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-assessmenttargetarn
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTargetArn { get; set; }

            /// <summary>
            /// DurationInSeconds
            /// The duration in seconds specified for this assessment tempate. The default value is 3600 seconds
            /// (one hour). The maximum value is 86400 seconds (one day).
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-durationinseconds
            /// </summary>
			public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

            /// <summary>
            /// AssessmentTemplateName
            /// The name of the assessment template.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-assessmenttemplatename
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTemplateName { get; set; }

            /// <summary>
            /// RulesPackageArns
            /// The rules packages that are specified for this assessment template.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-rulespackagearns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> RulesPackageArns { get; set; }

            /// <summary>
            /// UserAttributesForFindings
            /// The user-defined attributes that are assigned to every generated finding from the assessment run
            /// that uses this assessment template.
            /// Required: No
            /// Type: List of AWS CloudFormation Resource Tags
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html#cfn-inspector-assessmenttemplate-userattributesforfindings
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
