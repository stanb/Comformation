using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.Detector
{
    /// <summary>
    /// AWS::FraudDetector::Detector Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-frauddetector-detector-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// RuleId
        /// The rule ID.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[0-9a-z_-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleId")]
        public Union<string, IntrinsicFunction> RuleId { get; set; }

        /// <summary>
        /// RuleVersion
        /// The rule version.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 5
        /// Pattern: ^([1-9][0-9]*)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleVersion")]
        public Union<string, IntrinsicFunction> RuleVersion { get; set; }

        /// <summary>
        /// DetectorId
        /// The detector for which the rule is associated.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[0-9a-z_-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DetectorId")]
        public Union<string, IntrinsicFunction> DetectorId { get; set; }

        /// <summary>
        /// Expression
        /// The rule expression. A rule expression captures the business logic. For more information, see Rule
        /// language reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Language
        /// The rule language.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Language")]
        public Union<string, IntrinsicFunction> Language { get; set; }

        /// <summary>
        /// Outcomes
        /// The rule outcome.
        /// Required: No
        /// Type: List of Outcome
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Outcomes")]
        public List<Outcome> Outcomes { get; set; }

        /// <summary>
        /// Arn
        /// The rule ARN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// Description
        /// The rule description.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Tags
        /// An array of key-value pairs to apply to this resource.
        /// For more information, see Tag.
        /// Required: No
        /// Type: List of Tag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// CreatedTime
        /// Timestamp for when the rule was created.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreatedTime")]
        public Union<string, IntrinsicFunction> CreatedTime { get; set; }

        /// <summary>
        /// LastUpdatedTime
        /// Timestamp for when the rule was last updated.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LastUpdatedTime")]
        public Union<string, IntrinsicFunction> LastUpdatedTime { get; set; }

    }
}
