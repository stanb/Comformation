using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project Environment
    /// Environment is a property of the AWS::CodeBuild::Project resource that specifies the environment for an AWS
    /// CodeBuild project.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Type
        /// The type of build environment to use for related builds.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: LINUX_CONTAINER | WINDOWS_CONTAINER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// EnvironmentVariables
        /// A set of environment variables to make available to builds for this build project.
        /// Required: No
        /// Type: List of EnvironmentVariable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public List<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// PrivilegedMode
        /// Enables running the Docker daemon inside a Docker container. Set to true only if the build project
        /// is used to build Docker images. Otherwise, a build that attempts to interact with the Docker daemon
        /// fails.
        /// You can initialize the Docker daemon during the install phase of your build by adding one of the
        /// following sets of commands to the install phase of your buildspec file:
        /// If the operating system&#39;s base image is Ubuntu Linux:
        /// - nohup /usr/local/bin/dockerd --host=unix:///var/run/docker. sock --host=tcp://0. 0. 0. 0:2375
        /// --storage-driver=overlay&amp;amp;
        /// - timeout 15 sh -c &quot;until docker info; do echo . ; sleep 1; done&quot;
        /// If the operating system&#39;s base image is Alpine Linux and the previous command does not work, add the
        /// -t argument to timeout:
        /// - nohup /usr/local/bin/dockerd --host=unix:///var/run/docker. sock --host=tcp://0. 0. 0. 0:2375
        /// --storage-driver=overlay&amp;amp;
        /// - timeout -t 15 sh -c &quot;until docker info; do echo . ; sleep 1; done&quot;
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivilegedMode")]
        public Union<bool, IntrinsicFunction> PrivilegedMode { get; set; }

        /// <summary>
        /// ImagePullCredentialsType
        /// The type of credentials AWS CodeBuild uses to pull images in your build. There are two valid values:
        /// CODEBUILD specifies that AWS CodeBuild uses its own credentials. This requires that you modify your
        /// ECR repository policy to trust AWS CodeBuild&#39;s service principal. SERVICE_ROLE specifies that AWS
        /// CodeBuild uses your build project&#39;s service role.
        /// When you use a cross-account or private registry image, you must use SERVICE_ROLE credentials. When
        /// you use an AWS CodeBuild curated image, you must use CODEBUILD credentials.
        /// Required: No
        /// Type: String
        /// Allowed Values: CODEBUILD | SERVICE_ROLE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImagePullCredentialsType")]
        public Union<string, IntrinsicFunction> ImagePullCredentialsType { get; set; }

        /// <summary>
        /// Image
        /// The image tag or image digest that identifies the Docker image to use for this build project. Use
        /// the following formats:
        /// For an image tag: registry/repository:tag. For example, to specify an image with the tag &quot;latest,&quot;
        /// use registry/repository:latest. For an image digest: registry/repository@digest. For example, to
        /// specify an image with the digest
        /// &quot;sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf,&quot; use
        /// registry/repository@sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// RegistryCredential
        /// RegistryCredential is a property of the AWS::CodeBuild::Project Environment property that specifies
        /// information about credentials that provide access to a private Docker registry. When this is set:
        /// imagePullCredentialsType must be set to SERVICE_ROLE. images cannot be curated or an Amazon ECR
        /// image.
        /// Required: No
        /// Type: RegistryCredential
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegistryCredential")]
        public RegistryCredential RegistryCredential { get; set; }

        /// <summary>
        /// ComputeType
        /// The type of compute environment. This determines the number of CPU cores and memory the build
        /// environment uses. Available values include:
        /// BUILD_GENERAL1_SMALL: Use up to 3 GB memory and 2 vCPUs for builds. BUILD_GENERAL1_MEDIUM: Use up to
        /// 7 GB memory and 4 vCPUs for builds. BUILD_GENERAL1_LARGE: Use up to 15 GB memory and 8 vCPUs for
        /// builds.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeType")]
        public Union<string, IntrinsicFunction> ComputeType { get; set; }

        /// <summary>
        /// Certificate
        /// The certificate to use with this build project.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Certificate")]
        public Union<string, IntrinsicFunction> Certificate { get; set; }

    }
}
