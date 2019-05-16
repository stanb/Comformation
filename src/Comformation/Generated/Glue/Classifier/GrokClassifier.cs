using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    /// AWS::Glue::Classifier GrokClassifier
    /// A classifier that uses grok patterns.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-grokclassifier.html
    /// </summary>
    public class GrokClassifier
    {

        /// <summary>
        /// CustomPatterns
        /// Optional custom grok patterns defined by this classifier. For more information, see custom patterns
        /// in Writing Custom Classifiers.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomPatterns")]
        public Union<string, IntrinsicFunction> CustomPatterns { get; set; }

        /// <summary>
        /// GrokPattern
        /// The grok pattern applied to a data store by this classifier. For more information, see built-in
        /// patterns in Writing Custom Classifiers.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GrokPattern")]
        public Union<string, IntrinsicFunction> GrokPattern { get; set; }

        /// <summary>
        /// Classification
        /// An identifier of the data format that the classifier matches, such as Twitter, JSON, Omniture logs,
        /// and so on.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        /// Name
        /// The name of the classifier.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
