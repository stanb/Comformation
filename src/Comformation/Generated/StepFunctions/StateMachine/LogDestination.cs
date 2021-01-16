using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    /// AWS::StepFunctions::StateMachine LogDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-logdestination.html
    /// </summary>
    public class LogDestination
    {

        /// <summary>
        /// CloudWatchLogsLogGroup
        /// An object describing a CloudWatch log group. For more information, see AWS::Logs::LogGroup in the
        /// AWS CloudFormation User Guide.
        /// Required: No
        /// Type: CloudWatchLogsLogGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogsLogGroup")]
        public CloudWatchLogsLogGroup CloudWatchLogsLogGroup { get; set; }

    }
}
