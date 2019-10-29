using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask MaintenanceWindowStepFunctionsParameters
    /// The MaintenanceWindowStepFunctionsParameters property type specifies the parameters for the execution of a
    /// STEP_FUNCTIONS task in a Systems Manager maintenance window.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-maintenancewindowstepfunctionsparameters.html
    /// </summary>
    public class MaintenanceWindowStepFunctionsParameters
    {

        /// <summary>
        /// Input
        /// The inputs for the STEP_FUNCTIONS task.
        /// Required: No
        /// Type: String
        /// Maximum: 4096
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Input")]
        public Union<string, IntrinsicFunction> Input { get; set; }

        /// <summary>
        /// Name
        /// The name of the STEP_FUNCTIONS task.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 80
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
