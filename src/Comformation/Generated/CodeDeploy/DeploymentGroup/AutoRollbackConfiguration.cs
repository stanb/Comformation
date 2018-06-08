using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup AutoRollbackConfiguration
    /// The AutoRollbackConfiguration property type configures automatic rollback for an AWS CodeDeploy deployment
    /// group when a deployment doesn't complete successfully. For more information, see Automatic Rollbacks in the
    /// AWS CodeDeploy User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-autorollbackconfiguration.html
    /// </summary>
    public class AutoRollbackConfiguration
    {

        /// <summary>
        /// Enabled
        /// Indicates whether a defined automatic rollback configuration is currently enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Events
        /// The event type or types that trigger a rollback. Valid values are DEPLOYMENT_FAILURE,
        /// DEPLOYMENT_STOP_ON_ALARM, or DEPLOYMENT_STOP_ON_REQUEST.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Events")]
        public Union<List<string>, IntrinsicFunction> Events { get; set; }

    }
}
