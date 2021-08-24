using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.Detector
{
    /// <summary>
    /// AWS::FraudDetector::Detector Model
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-frauddetector-detector-model.html
    /// </summary>
    public class Model
    {

        /// <summary>
        /// Arn
        /// The ARN of the model.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^arn\:aws[a-z-]{0,15}\:frauddetector\:[a-z0-9-]{3,20}\:[0-9]{12}\:[^\s]{2,128}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
