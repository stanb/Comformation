using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DataQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::DataQualityJobDefinition ConstraintsResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-constraintsresource.html
    /// </summary>
    public class ConstraintsResource
    {

        /// <summary>
        /// S3Uri
        /// The Amazon S3 URI for the constraints resource.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3Uri")]
        public Union<string, IntrinsicFunction> S3Uri { get; set; }

    }
}
