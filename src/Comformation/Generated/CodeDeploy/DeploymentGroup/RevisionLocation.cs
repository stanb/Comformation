using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup Deployment Revision
    /// Revision is a property of the AWS::CodeDeploy::DeploymentGroup property that defines the location of the AWS
    /// CodeDeploy application revision to deploy.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment-revision.html
    /// </summary>
    public class RevisionLocation
    {

        /// <summary>
        /// GitHubLocation
        /// If your application revision is stored in GitHub, information about the location where it is stored.
        /// Required: No
        /// Type: AWS CodeDeploy DeploymentGroup Deployment Revision GitHubLocation
        /// </summary>
        [JsonProperty("GitHubLocation")]
        public Union<GitHubLocation, IntrinsicFunction> GitHubLocation { get; set; }

        /// <summary>
        /// RevisionType
        /// The application revision's location, such as in an S3 bucket or GitHub repository. For valid values,
        /// see RevisionLocation in the AWS CodeDeploy API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RevisionType")]
        public Union<string, IntrinsicFunction> RevisionType { get; set; }

        /// <summary>
        /// S3Location
        /// If the application revision is stored in an S3 bucket, information about the location.
        /// Required: No
        /// Type: AWS CodeDeploy DeploymentGroup Deployment Revision S3Location
        /// </summary>
        [JsonProperty("S3Location")]
        public Union<S3Location, IntrinsicFunction> S3Location { get; set; }

    }
}
