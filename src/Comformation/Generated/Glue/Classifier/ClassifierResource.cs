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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-classifier.html
    /// </summary>
    public class ClassifierResource : ResourceBase
    {
        public class ClassifierProperties
        {
            /// <summary>
            /// GrokClassifier
            /// A classifier that uses grok.
            /// Required: No
            /// Type: AWS Glue Classifier GrokClassifier
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-classifier.html#cfn-glue-classifier-grokclassifier
            /// </summary>
			public Union<GrokClassifier, IntrinsicFunction> GrokClassifier { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Classifier";
        
        public ClassifierProperties Properties { get; } = new ClassifierProperties();
    }
}
