using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.Detector
{
    /// <summary>
    /// AWS::FraudDetector::Detector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-frauddetector-detector.html
    /// </summary>
    public class DetectorResource : ResourceBase
    {
        public class DetectorProperties
        {
            /// <summary>
            /// DetectorId
            /// The name of the detector.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ^[0-9a-z_-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DetectorId { get; set; }

            /// <summary>
            /// DetectorVersionStatus
            /// The status of the detector version. If a value is not provided for this property, AWS CloudFormation
            /// assumes DRAFT status.
            /// Valid values: ACTIVE | DRAFT
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DetectorVersionStatus { get; set; }

            /// <summary>
            /// RuleExecutionMode
            /// The rule execution mode for the rules included in the detector version.
            /// Valid values: FIRST_MATCHED | ALL_MATCHED Default value: FIRST_MATCHED
            /// You can define and edit the rule mode at the detector version level, when it is in draft status.
            /// If you specify FIRST_MATCHED, Amazon Fraud Detector evaluates rules sequentially, first to last,
            /// stopping at the first matched rule. Amazon Fraud dectector then provides the outcomes for that
            /// single rule.
            /// If you specifiy ALL_MATCHED, Amazon Fraud Detector evaluates all rules and returns the outcomes for
            /// all matched rules.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleExecutionMode { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Description
            /// The detector description.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Rules
            /// The rules to include in the detector version.
            /// Required: Yes
            /// Type: List of Rule
            /// Update requires: No interruption
            /// </summary>
            public List<Rule> Rules { get; set; }

            /// <summary>
            /// EventType
            /// The event type associated with this detector.
            /// Required: Yes
            /// Type: EventType
            /// Update requires: No interruption
            /// </summary>
            public EventType EventType { get; set; }

            /// <summary>
            /// AssociatedModels
            /// The models to associate with this detector. You must provide the ARNs of all the models you want to
            /// associate.
            /// Required: No
            /// Type: List of Model
            /// Update requires: No interruption
            /// </summary>
            public List<Model> AssociatedModels { get; set; }

        }

        public string Type { get; } = "AWS::FraudDetector::Detector";

        public DetectorProperties Properties { get; } = new DetectorProperties();

    }

    public static class DetectorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DetectorVersionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DetectorVersionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EventType_Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("EventType", "Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EventType_CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("EventType", "CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EventType_LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("EventType", "LastUpdatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
    }
}
