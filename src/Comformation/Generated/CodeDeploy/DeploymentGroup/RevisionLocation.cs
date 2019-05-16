using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup RevisionLocation
    /// RevisionLocation is a property that defines the location of the CodeDeploy application revision to deploy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment-revision.html
    /// </summary>
    public class RevisionLocation
    {

        /// <summary>
        /// GitHubLocation
        /// Information about the location of application artifacts stored in GitHub.
        /// Required: No
        /// Type: GitHubLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GitHubLocation")]
        public GitHubLocation GitHubLocation { get; set; }

        /// <summary>
        /// RevisionType
        /// The type of application revision:
        /// S3: An application revision stored in Amazon S3. GitHub: An application revision stored in GitHub
        /// (EC2/On-premises deployments only). String: A YAML-formatted or JSON-formatted string (AWS Lambda
        /// deployments only).
        /// Required: No
        /// Type: String
        /// Allowed Values: AppSpecContent | GitHub | S3 | String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RevisionType")]
        public Union<string, IntrinsicFunction> RevisionType { get; set; }

        /// <summary>
        /// S3Location
        /// Information about the location of a revision stored in Amazon S3.
        /// Required: No
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Location")]
        public S3Location S3Location { get; set; }

    }
}
