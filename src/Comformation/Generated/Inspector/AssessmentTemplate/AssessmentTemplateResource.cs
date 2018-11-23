using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTemplate
{
    /// <summary>
    /// AWS::Inspector::AssessmentTemplate
    /// The AWS::Inspector::AssessmentTemplate resource creates an Amazon Inspector assessment template - a resource
    /// that contains information about an Amazon Inspector assessment template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html
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
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTargetArn { get; set; }

            /// <summary>
            /// DurationInSeconds
            /// The duration in seconds specified for this assessment tempate. The default value is 3600 seconds
            /// (one hour). The maximum value is 86400 seconds (one day).
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

            /// <summary>
            /// AssessmentTemplateName
            /// The name of the assessment template.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AssessmentTemplateName { get; set; }

            /// <summary>
            /// RulesPackageArns
            /// The rules packages that are specified for this assessment template.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RulesPackageArns { get; set; }

            /// <summary>
            /// UserAttributesForFindings
            /// The user-defined attributes that are assigned to every generated finding from the assessment run
            /// that uses this assessment template.
            /// Required: No
            /// Type: List of Resource Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> UserAttributesForFindings { get; set; }

        }

        public string Type { get; } = "AWS::Inspector::AssessmentTemplate";

        public AssessmentTemplateProperties Properties { get; } = new AssessmentTemplateProperties();

    }

	public static class AssessmentTemplateAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
