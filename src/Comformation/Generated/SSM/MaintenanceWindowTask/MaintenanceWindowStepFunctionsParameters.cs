using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS Systems Manager MaintenanceWindowTask MaintenanceWindowStepFunctionsParameters
    /// The MaintenanceWindowStepFunctionsParameters property type specifies the parameters for execution of the
    /// STEP_FUNCTION for a Maintenance Window task in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowstepfunctionsparameters.html
    /// </summary>
    public class MaintenanceWindowStepFunctionsParameters
    {

        /// <summary>
        /// Input
        /// The inputs for the STEP_FUNCTION task.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Input")]
        public Union<string, IntrinsicFunction> Input { get; set; }

        /// <summary>
        /// Name
        /// The name of the STEP_FUNCTION task.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
