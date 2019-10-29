using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    /// AWS::Glue::Classifier
    /// The AWS::Glue::Classifier resource creates an AWS Glue classifier that categorizes data sources and specifies
    /// schemas. For more information, see Adding Classifiers to a Crawler and Classifier Structure in the AWS Glue
    /// Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-classifier.html
    /// </summary>
    public class ClassifierResource : ResourceBase
    {
        public class ClassifierProperties
        {
            /// <summary>
            /// XMLClassifier
            /// A classifier for XML content.
            /// Required: No
            /// Type: XMLClassifier
            /// Update requires: No interruption
            /// </summary>
			public XMLClassifier XMLClassifier { get; set; }

            /// <summary>
            /// JsonClassifier
            /// A classifier for JSON content.
            /// Required: No
            /// Type: JsonClassifier
            /// Update requires: No interruption
            /// </summary>
			public JsonClassifier JsonClassifier { get; set; }

            /// <summary>
            /// CsvClassifier
            /// A classifier for comma-separated values (CSV).
            /// Required: No
            /// Type: CsvClassifier
            /// Update requires: No interruption
            /// </summary>
			public CsvClassifier CsvClassifier { get; set; }

            /// <summary>
            /// GrokClassifier
            /// A classifier that uses grok.
            /// Required: No
            /// Type: GrokClassifier
            /// Update requires: No interruption
            /// </summary>
			public GrokClassifier GrokClassifier { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Classifier";

        public ClassifierProperties Properties { get; } = new ClassifierProperties();

    }
}
