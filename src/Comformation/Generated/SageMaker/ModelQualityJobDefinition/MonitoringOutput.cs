using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelQualityJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelQualityJobDefinition MonitoringOutput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-monitoringoutput.html
    /// </summary>
    public class MonitoringOutput
    {

        /// <summary>
        /// S3Output
        /// The Amazon S3 storage location where the results of a monitoring job are saved.
        /// Required: Yes
        /// Type: S3Output
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3Output")]
        public S3Output S3Output { get; set; }

    }
}
