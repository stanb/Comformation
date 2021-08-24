using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition FargatePlatformConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-fargateplatformconfiguration.html
    /// </summary>
    public class FargatePlatformConfiguration
    {

        /// <summary>
        /// PlatformVersion
        /// The AWS Fargate platform version where the jobs are running. A platform version is specified only
        /// for jobs that are running on Fargate resources. If one isn&#39;t specified, the LATEST platform version
        /// is used by default. This uses a recent, approved version of the AWS Fargate platform for compute
        /// resources. For more information, see AWS Fargate platform versions in the Amazon Elastic Container
        /// Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PlatformVersion")]
        public Union<string, IntrinsicFunction> PlatformVersion { get; set; }

    }
}
