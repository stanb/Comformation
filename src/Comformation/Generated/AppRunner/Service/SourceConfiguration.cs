using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service SourceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-sourceconfiguration.html
    /// </summary>
    public class SourceConfiguration
    {

        /// <summary>
        /// CodeRepository
        /// The description of a source code repository.
        /// You must provide either this member or ImageRepository (but not both).
        /// Required: No
        /// Type: CodeRepository
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeRepository")]
        public CodeRepository CodeRepository { get; set; }

        /// <summary>
        /// ImageRepository
        /// The description of a source image repository.
        /// You must provide either this member or CodeRepository (but not both).
        /// Required: No
        /// Type: ImageRepository
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageRepository")]
        public ImageRepository ImageRepository { get; set; }

        /// <summary>
        /// AutoDeploymentsEnabled
        /// If true, continuous integration from the source repository is enabled for the App Runner service.
        /// Each repository change (including any source code commit or new image version) starts a deployment.
        /// Default: App Runner sets to false for a source image that uses an ECR Public repository or an ECR
        /// repository that&#39;s in an AWS account other than the one that the service is in. App Runner sets to
        /// true in all other cases (which currently include a source code repository or a source image using a
        /// same-account ECR repository).
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoDeploymentsEnabled")]
        public Union<bool, IntrinsicFunction> AutoDeploymentsEnabled { get; set; }

        /// <summary>
        /// AuthenticationConfiguration
        /// Describes the resources that are needed to authenticate access to some source repositories.
        /// Required: No
        /// Type: AuthenticationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticationConfiguration")]
        public AuthenticationConfiguration AuthenticationConfiguration { get; set; }

    }
}
