using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.UserProfile
{
    /// <summary>
    /// AWS::SageMaker::UserProfile UserSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html
    /// </summary>
    public class UserSettings
    {

        /// <summary>
        /// ExecutionRole
        /// The execution role for the user.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecutionRole")]
        public Union<string, IntrinsicFunction> ExecutionRole { get; set; }

        /// <summary>
        /// JupyterServerAppSettings
        /// The Jupyter server&#39;s app settings.
        /// Required: No
        /// Type: JupyterServerAppSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JupyterServerAppSettings")]
        public JupyterServerAppSettings JupyterServerAppSettings { get; set; }

        /// <summary>
        /// KernelGatewayAppSettings
        /// The kernel gateway app settings.
        /// Required: No
        /// Type: KernelGatewayAppSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KernelGatewayAppSettings")]
        public KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }

        /// <summary>
        /// SecurityGroups
        /// The security groups for the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.
        /// Optional when the CreateDomain. AppNetworkAccessType parameter is set to PublicInternetOnly.
        /// Required when the CreateDomain. AppNetworkAccessType parameter is set to VpcOnly.
        /// Amazon SageMaker adds a security group to allow NFS traffic from SageMaker Studio. Therefore, the
        /// number of security groups that you can specify is one less than the maximum number shown.
        /// Required: No
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// SharingSettings
        /// Specifies options for sharing SageMaker Studio notebooks.
        /// Required: No
        /// Type: SharingSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SharingSettings")]
        public SharingSettings SharingSettings { get; set; }

    }
}
