using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentConfig MinimumHealthyHosts
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html
    /// </summary>
    public class MinimumHealthyHosts
    {

        /// <summary>
        /// Type
        /// The minimum healthy instance type:
        /// HOST_COUNT: The minimum number of healthy instance as an absolute value. FLEET_PERCENT: The minimum
        /// number of healthy instance as a percentage of the total number of instance in the deployment.
        /// In an example of nine instance, if a HOST_COUNT of six is specified, deploy to up to three instances
        /// at a time. The deployment is successful if six or more instances are deployed to successfully.
        /// Otherwise, the deployment fails. If a FLEET_PERCENT of 40 is specified, deploy to up to five
        /// instance at a time. The deployment is successful if four or more instance are deployed to
        /// successfully. Otherwise, the deployment fails.
        /// Note In a call to GetDeploymentConfig, CodeDeployDefault. OneAtATime returns a minimum healthy
        /// instance type of MOST_CONCURRENCY and a value of 1. This means a deployment to only one instance at
        /// a time. (You cannot set the type to MOST_CONCURRENCY, only to HOST_COUNT or FLEET_PERCENT. ) In
        /// addition, with CodeDeployDefault. OneAtATime, AWS CodeDeploy attempts to ensure that all instances
        /// but one are kept in a healthy state during the deployment. Although this allows one instance at a
        /// time to be taken offline for a new deployment, it also means that if the deployment to the last
        /// instance fails, the overall deployment is still successful.
        /// For more information, see AWS CodeDeploy Instance Health in the AWS CodeDeploy User Guide.
        /// Required: Yes
        /// Type: String
        /// Allowed values: FLEET_PERCENT | HOST_COUNT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The minimum healthy instance value.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<int, IntrinsicFunction> Value { get; set; }

    }
}
