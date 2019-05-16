using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask MaintenanceWindowAutomationParameters
    /// The MaintenanceWindowAutomationParameters property type specifies the parameters for an AUTOMATION task type
    /// for a Maintenance Window task in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowautomationparameters.html
    /// </summary>
    public class MaintenanceWindowAutomationParameters
    {

        /// <summary>
        /// Parameters
        /// The parameters for the AUTOMATION task.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// DocumentVersion
        /// The version of an Automation document to use during task execution.
        /// Required: No
        /// Type: String
        /// Pattern: ([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentVersion")]
        public Union<string, IntrinsicFunction> DocumentVersion { get; set; }

    }
}
