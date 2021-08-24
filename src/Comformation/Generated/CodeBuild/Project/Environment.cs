using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project Environment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html
    /// </summary>
    public class Environment
    {

        /// <summary>
        /// Type
        /// The type of build environment to use for related builds.
        /// The environment type ARM_CONTAINER is available only in regions US East (N. Virginia), US East
        /// (Ohio), US West (Oregon), EU (Ireland), Asia Pacific (Mumbai), Asia Pacific (Tokyo), Asia Pacific
        /// (Sydney), and EU (Frankfurt). The environment type LINUX_CONTAINER with compute type build.
        /// general1. 2xlarge is available only in regions US East (N. Virginia), US East (Ohio), US West
        /// (Oregon), Canada (Central), EU (Ireland), EU (London), EU (Frankfurt), Asia Pacific (Tokyo), Asia
        /// Pacific (Seoul), Asia Pacific (Singapore), Asia Pacific (Sydney), China (Beijing), and China
        /// (Ningxia). The environment type LINUX_GPU_CONTAINER is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), Canada (Central), EU (Ireland), EU (London), EU
        /// (Frankfurt), Asia Pacific (Tokyo), Asia Pacific (Seoul), Asia Pacific (Singapore), Asia Pacific
        /// (Sydney) , China (Beijing), and China (Ningxia).
        /// The environment types WINDOWS_CONTAINER and WINDOWS_SERVER_2019_CONTAINER are available only in
        /// regions US East (N. Virginia), US East (Ohio), US West (Oregon), and EU (Ireland).
        /// For more information, see Build environment compute types in the AWS CodeBuild user guide.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ARM_CONTAINER | LINUX_CONTAINER | LINUX_GPU_CONTAINER | WINDOWS_CONTAINER |
        /// WINDOWS_SERVER_2019_CONTAINER
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
        /// fails. The default setting is false.
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
        /// ECR repository policy to trust AWS CodeBuild service principal. SERVICE_ROLE specifies that AWS
        /// CodeBuild uses your build project&#39;s service role.
        /// When you use a cross-account or private registry image, you must use SERVICE_ROLE credentials. When
        /// you use an AWS CodeBuild curated image, you must use CODEBUILD credentials.
        /// Required: No
        /// Type: String
        /// Allowed values: CODEBUILD | SERVICE_ROLE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImagePullCredentialsType")]
        public Union<string, IntrinsicFunction> ImagePullCredentialsType { get; set; }

        /// <summary>
        /// Image
        /// The image tag or image digest that identifies the Docker image to use for this build project. Use
        /// the following formats:
        /// For an image tag: &amp;lt;registry&amp;gt;/&amp;lt;repository&amp;gt;:&amp;lt;tag&amp;gt;. For example, in the Docker
        /// repository that CodeBuild uses to manage its Docker images, this would be aws/codebuild/standard:4.
        /// 0. For an image digest: &amp;lt;registry&amp;gt;/&amp;lt;repository&amp;gt;@&amp;lt;digest&amp;gt;. For example, to specify
        /// an image with the digest &quot;sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf,&quot;
        /// use
        /// &amp;lt;registry&amp;gt;/&amp;lt;repository&amp;gt;@sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf.
        /// For more information, see Docker images provided by CodeBuild in the AWS CodeBuild user guide.
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
        /// For more information, see Build Environment Compute Types in the AWS CodeBuild User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeType")]
        public Union<string, IntrinsicFunction> ComputeType { get; set; }

        /// <summary>
        /// Certificate
        /// The ARN of the Amazon S3 bucket, path prefix, and object key that contains the PEM-encoded
        /// certificate for the build project. For more information, see certificate in the AWS CodeBuild User
        /// Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Certificate")]
        public Union<string, IntrinsicFunction> Certificate { get; set; }

    }
}
