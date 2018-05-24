using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html
    /// </summary>
    public class TaskInvocationParameters
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowruncommandparameters
        /// </summary>
        [JsonProperty("MaintenanceWindowRunCommandParameters")]
        public Union<MaintenanceWindowRunCommandParameters, IntrinsicFunction> MaintenanceWindowRunCommandParameters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowautomationparameters
        /// </summary>
        [JsonProperty("MaintenanceWindowAutomationParameters")]
        public Union<MaintenanceWindowAutomationParameters, IntrinsicFunction> MaintenanceWindowAutomationParameters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowstepfunctionsparameters
        /// </summary>
        [JsonProperty("MaintenanceWindowStepFunctionsParameters")]
        public Union<MaintenanceWindowStepFunctionsParameters, IntrinsicFunction> MaintenanceWindowStepFunctionsParameters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowlambdaparameters
        /// </summary>
        [JsonProperty("MaintenanceWindowLambdaParameters")]
        public Union<MaintenanceWindowLambdaParameters, IntrinsicFunction> MaintenanceWindowLambdaParameters { get; set; }

    }
}
