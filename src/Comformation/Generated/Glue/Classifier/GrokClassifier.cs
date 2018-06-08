using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    /// AWS Glue Classifier GrokClassifier
    /// The GrokClassifier property type specifies an AWS Glue classifier that uses grok.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-grokclassifier.html
    /// </summary>
    public class GrokClassifier
    {

        /// <summary>
        /// CustomPatterns
        /// Custom grok patterns that are used by this classifier. It must match the URI address multi-line
        /// string pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomPatterns")]
        public Union<string, IntrinsicFunction> CustomPatterns { get; set; }

        /// <summary>
        /// GrokPattern
        /// The grok pattern that's used by this classifier. It must match the Logstash grok string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GrokPattern")]
        public Union<string, IntrinsicFunction> GrokPattern { get; set; }

        /// <summary>
        /// Classification
        /// The data form that the classifier matches—such as Twitter, JSON, or Omniture logs.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        /// Name
        /// The name of the classifier. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
