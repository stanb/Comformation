using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Inspector.AssessmentTemplate
{
    /// <summary>
    /// AWS::Inspector::AssessmentTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-assessmenttemplate.html
    /// </summary>
    public class AssessmentTemplateResource : ResourceBase
    {
        public class AssessmentTemplateProperties
        {
            /// <summary>
            /// AssessmentTargetArn
            /// The ARN of the assessment target to be included in the assessment template.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AssessmentTargetArn { get; set; }

            /// <summary>
            /// DurationInSeconds
            /// The duration of the assessment run in seconds.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 180
            /// Maximum: 86400
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> DurationInSeconds { get; set; }

            /// <summary>
            /// AssessmentTemplateName
            /// The user-defined name that identifies the assessment template that you want to create. You can
            /// create several assessment templates for the same assessment target. The names of the assessment
            /// templates that correspond to a particular assessment target must be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AssessmentTemplateName { get; set; }

            /// <summary>
            /// RulesPackageArns
            /// The ARNs of the rules packages that you want to use in the assessment template.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> RulesPackageArns { get; set; }

            /// <summary>
            /// UserAttributesForFindings
            /// The user-defined attributes that are assigned to every finding that is generated by the assessment
            /// run that uses this assessment template. Within an assessment template, each key must be unique.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 10
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
