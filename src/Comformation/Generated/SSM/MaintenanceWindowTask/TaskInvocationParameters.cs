using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask TaskInvocationParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html
    /// </summary>
    public class TaskInvocationParameters
    {

        /// <summary>
        /// MaintenanceWindowRunCommandParameters
        /// The parameters for a RUN_COMMAND task type.
        /// Required: No
        /// Type: MaintenanceWindowRunCommandParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaintenanceWindowRunCommandParameters")]
        public MaintenanceWindowRunCommandParameters MaintenanceWindowRunCommandParameters { get; set; }

        /// <summary>
        /// MaintenanceWindowAutomationParameters
        /// The parameters for an AUTOMATION task type.
        /// Required: No
        /// Type: MaintenanceWindowAutomationParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaintenanceWindowAutomationParameters")]
        public MaintenanceWindowAutomationParameters MaintenanceWindowAutomationParameters { get; set; }

        /// <summary>
        /// MaintenanceWindowStepFunctionsParameters
        /// The parameters for a STEP_FUNCTIONS task type.
        /// Required: No
        /// Type: MaintenanceWindowStepFunctionsParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaintenanceWindowStepFunctionsParameters")]
        public MaintenanceWindowStepFunctionsParameters MaintenanceWindowStepFunctionsParameters { get; set; }

        /// <summary>
        /// MaintenanceWindowLambdaParameters
        /// The parameters for a LAMBDA task type.
        /// Required: No
        /// Type: MaintenanceWindowLambdaParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaintenanceWindowLambdaParameters")]
        public MaintenanceWindowLambdaParameters MaintenanceWindowLambdaParameters { get; set; }

    }
}
