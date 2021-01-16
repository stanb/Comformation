using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup TriggerConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-triggerconfig.html
    /// </summary>
    public class TriggerConfig
    {

        /// <summary>
        /// TriggerEvents
        /// The event type or types that trigger notifications.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerEvents")]
        public List<Union<string, IntrinsicFunction>> TriggerEvents { get; set; }

        /// <summary>
        /// TriggerName
        /// The name of the notification trigger.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerName")]
        public Union<string, IntrinsicFunction> TriggerName { get; set; }

        /// <summary>
        /// TriggerTargetArn
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service topic through which
        /// notifications about deployment or instance events are sent.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerTargetArn")]
        public Union<string, IntrinsicFunction> TriggerTargetArn { get; set; }

    }
}
