using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-classifier.html
    /// </summary>
    public class ClassifierResource : ResourceBase
    {
        public class ClassifierProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-classifier.html#cfn-glue-classifier-grokclassifier
            /// </summary>
			public Union<GrokClassifier, IntrinsicFunction> GrokClassifier { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Classifier";
        
        public ClassifierProperties Properties { get; } = new ClassifierProperties();
    }
}
