using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup Alarm
    /// The Alarm property type specifies a CloudWatch alarm to use for an AWS CodeDeploy deployment group. The Alarm
    /// property of the CodeDeploy DeploymentGroup AlarmConfiguration property contains a list of Alarm property
    /// types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-alarm.html
    /// </summary>
    public class Alarm
    {

        /// <summary>
        /// Name
        /// The name of the alarm. Maximum length is 255 characters. Each alarm name can be used only once in a
        /// list of alarms.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
