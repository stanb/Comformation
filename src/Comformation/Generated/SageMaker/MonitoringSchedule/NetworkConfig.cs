using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule NetworkConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-networkconfig.html
    /// </summary>
    public class NetworkConfig
    {

        /// <summary>
        /// EnableInterContainerTrafficEncryption
        /// Whether to encrypt all communications between distributed processing jobs. Choose True to encrypt
        /// communications. Encryption provides greater security for distributed processing jobs, but the
        /// processing might take longer.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableInterContainerTrafficEncryption")]
        public Union<bool, IntrinsicFunction> EnableInterContainerTrafficEncryption { get; set; }

        /// <summary>
        /// EnableNetworkIsolation
        /// Whether to allow inbound and outbound network calls to and from the containers used for the
        /// processing job.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableNetworkIsolation")]
        public Union<bool, IntrinsicFunction> EnableNetworkIsolation { get; set; }

        /// <summary>
        /// VpcConfig
        /// Specifies a VPC that your training jobs and hosted models have access to. Control access to and from
        /// your training and model containers by configuring the VPC. For more information, see Protect
        /// Endpoints by Using an Amazon Virtual Private Cloud and Protect Training Jobs by Using an Amazon
        /// Virtual Private Cloud.
        /// Required: No
        /// Type: VpcConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig { get; set; }

    }
}
