using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.UserProfile
{
    /// <summary>
    /// AWS::SageMaker::UserProfile ResourceSpec
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html
    /// </summary>
    public class ResourceSpec
    {

        /// <summary>
        /// InstanceType
        /// The instance type that the image version runs on.
        /// Required: No
        /// Type: String
        /// Allowed values: ml. c5. 12xlarge | ml. c5. 18xlarge | ml. c5. 24xlarge | ml. c5. 2xlarge | ml. c5.
        /// 4xlarge | ml. c5. 9xlarge | ml. c5. large | ml. c5. xlarge | ml. g4dn. 12xlarge | ml. g4dn. 16xlarge
        /// | ml. g4dn. 2xlarge | ml. g4dn. 4xlarge | ml. g4dn. 8xlarge | ml. g4dn. xlarge | ml. m5. 12xlarge |
        /// ml. m5. 16xlarge | ml. m5. 24xlarge | ml. m5. 2xlarge | ml. m5. 4xlarge | ml. m5. 8xlarge | ml. m5.
        /// large | ml. m5. xlarge | ml. m5d. 12xlarge | ml. m5d. 16xlarge | ml. m5d. 24xlarge | ml. m5d.
        /// 2xlarge | ml. m5d. 4xlarge | ml. m5d. 8xlarge | ml. m5d. large | ml. m5d. xlarge | ml. p3. 16xlarge
        /// | ml. p3. 2xlarge | ml. p3. 8xlarge | ml. p3dn. 24xlarge | ml. r5. 12xlarge | ml. r5. 16xlarge | ml.
        /// r5. 24xlarge | ml. r5. 2xlarge | ml. r5. 4xlarge | ml. r5. 8xlarge | ml. r5. large | ml. r5. xlarge
        /// | ml. t3. 2xlarge | ml. t3. large | ml. t3. medium | ml. t3. micro | ml. t3. small | ml. t3. xlarge
        /// | system
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// SageMakerImageArn
        /// The ARN of the SageMaker image that the image version belongs to.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: ^arn:aws(-[\w]+)*:sagemaker:. +:[0-9]{12}:image/[a-z0-9]([-. ]?[a-z0-9])*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SageMakerImageArn")]
        public Union<string, IntrinsicFunction> SageMakerImageArn { get; set; }

        /// <summary>
        /// SageMakerImageVersionArn
        /// The ARN of the image version created on the instance.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: ^arn:aws(-[\w]+)*:sagemaker:. +:[0-9]{12}:image-version/[a-z0-9]([-. ]?[a-z0-9])*/[0-9]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SageMakerImageVersionArn")]
        public Union<string, IntrinsicFunction> SageMakerImageVersionArn { get; set; }

    }
}
