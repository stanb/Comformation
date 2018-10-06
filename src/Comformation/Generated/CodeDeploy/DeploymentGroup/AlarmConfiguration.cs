using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup AlarmConfiguration
    /// The AlarmConfiguration property type configures CloudWatch alarms for an AWS CodeDeploy deployment group.
    /// AlarmConfiguration is a property of the AWS::CodeDeploy::DeploymentGroup resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-alarmconfiguration.html
    /// </summary>
    public class AlarmConfiguration
    {

        /// <summary>
        /// Alarms
        /// The list of alarms configured for the deployment group. Duplicates are not allowed.
        /// Required: No
        /// Type: List of AWS CodeDeploy DeploymentGroup Alarm
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Alarms")]
        public List<Alarm> Alarms { get; set; }

        /// <summary>
        /// Enabled
        /// Indicates whether the alarm configuration is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// IgnorePollAlarmFailure
        /// Indicates whether a deployment should continue if information about the current state of alarms
        /// cannot be retrieved from CloudWatch. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnorePollAlarmFailure")]
        public Union<bool, IntrinsicFunction> IgnorePollAlarmFailure { get; set; }

    }
}
