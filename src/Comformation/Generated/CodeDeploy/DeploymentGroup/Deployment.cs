using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// CodeDeploy DeploymentGroup Deployment
    /// Deployment is a property of the AWS::CodeDeploy::DeploymentGroup resource that specifies an CodeDeploy
    /// application revision to be deployed to instances in the deployment group. If you specify an application
    /// revision, your target revision will be deployed as soon as the provisioning process is complete.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment.html
    /// </summary>
    public class Deployment
    {

        /// <summary>
        /// Description
        /// A description about this deployment.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// IgnoreApplicationStopFailures
        /// Whether to continue the deployment if the ApplicationStop deployment lifecycle event fails. If you
        /// want CodeDeploy to continue the deployment lifecycle even if the ApplicationStop event fails on an
        /// instance, specify true. The deployment continues to the BeforeInstall deployment lifecycle event. If
        /// you want CodeDeploy to stop deployment on the instance if the ApplicationStop event fails, specify
        /// false or do not specify a value.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("IgnoreApplicationStopFailures")]
        public Union<bool, IntrinsicFunction> IgnoreApplicationStopFailures { get; set; }

        /// <summary>
        /// Revision
        /// The location of the application revision to deploy.
        /// Required: Yes
        /// Type: CodeDeploy DeploymentGroup Revision
        /// </summary>
        [JsonProperty("Revision")]
        public RevisionLocation Revision { get; set; }

    }
}
