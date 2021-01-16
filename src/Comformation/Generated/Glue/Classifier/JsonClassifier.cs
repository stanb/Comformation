using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    /// AWS::Glue::Classifier JsonClassifier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-jsonclassifier.html
    /// </summary>
    public class JsonClassifier
    {

        /// <summary>
        /// JsonPath
        /// A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset
        /// of JsonPath, as described in Writing JsonPath Custom Classifiers.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonPath")]
        public Union<string, IntrinsicFunction> JsonPath { get; set; }

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
