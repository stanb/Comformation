using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup GitHubLocation
    /// GitHubLocation is a property of the CodeDeploy DeploymentGroup Revision property that specifies the location
    /// of an application revision that is stored in GitHub.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment-revision-githublocation.html
    /// </summary>
    public class GitHubLocation
    {

        /// <summary>
        /// CommitId
        /// The SHA1 commit ID of the GitHub commit that represents the bundled artifacts for the application
        /// revision.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CommitId")]
        public Union<string, IntrinsicFunction> CommitId { get; set; }

        /// <summary>
        /// Repository
        /// The GitHub account and repository pair that stores a reference to the commit that represents the
        /// bundled artifacts for the application revision.
        /// Specify the value as account/repository.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Repository")]
        public Union<string, IntrinsicFunction> Repository { get; set; }

    }
}
