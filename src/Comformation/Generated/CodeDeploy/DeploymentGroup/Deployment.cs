using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup Deployment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment.html
    /// </summary>
    public class Deployment
    {

        /// <summary>
        /// Description
        /// A comment about the deployment.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// IgnoreApplicationStopFailures
        /// If true, then if an ApplicationStop, BeforeBlockTraffic, or AfterBlockTraffic deployment lifecycle
        /// event to an instance fails, then the deployment continues to the next deployment lifecycle event.
        /// For example, if ApplicationStop fails, the deployment continues with DownloadBundle. If
        /// BeforeBlockTraffic fails, the deployment continues with BlockTraffic. If AfterBlockTraffic fails,
        /// the deployment continues with ApplicationStop.
        /// If false or not specified, then if a lifecycle event fails during a deployment to an instance, that
        /// deployment fails. If deployment to that instance is part of an overall deployment and the number of
        /// healthy hosts is not less than the minimum number of healthy hosts, then a deployment to the next
        /// instance is attempted.
        /// During a deployment, the AWS CodeDeploy agent runs the scripts specified for ApplicationStop,
        /// BeforeBlockTraffic, and AfterBlockTraffic in the AppSpec file from the previous successful
        /// deployment. (All other scripts are run from the AppSpec file in the current deployment. ) If one of
        /// these scripts contains an error and does not run successfully, the deployment can fail.
        /// If the cause of the failure is a script from the last successful deployment that will never run
        /// successfully, create a new deployment and use ignoreApplicationStopFailures to specify that the
        /// ApplicationStop, BeforeBlockTraffic, and AfterBlockTraffic failures should be ignored.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnoreApplicationStopFailures")]
        public Union<bool, IntrinsicFunction> IgnoreApplicationStopFailures { get; set; }

        /// <summary>
        /// Revision
        /// Information about the location of stored application artifacts and the service from which to
        /// retrieve them.
        /// Required: Yes
        /// Type: RevisionLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Revision")]
        public RevisionLocation Revision { get; set; }

    }
}
