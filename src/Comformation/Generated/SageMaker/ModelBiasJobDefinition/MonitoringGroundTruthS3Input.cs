using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelBiasJobDefinition
{
    /// <summary>
    /// AWS::SageMaker::ModelBiasJobDefinition MonitoringGroundTruthS3Input
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringgroundtruths3input.html
    /// </summary>
    public class MonitoringGroundTruthS3Input
    {

        /// <summary>
        /// S3Uri
        /// The address of the Amazon S3 location of the ground truth labels.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3Uri")]
        public Union<string, IntrinsicFunction> S3Uri { get; set; }

    }
}
