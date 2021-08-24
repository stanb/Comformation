using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule StepFunctionsAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-stepfunctionsaction.html
    /// </summary>
    public class StepFunctionsAction
    {

        /// <summary>
        /// ExecutionNamePrefix
        /// (Optional) A name will be given to the state machine execution consisting of this prefix followed by
        /// a UUID. Step Functions automatically creates a unique name for each state machine execution if one
        /// is not provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecutionNamePrefix")]
        public Union<string, IntrinsicFunction> ExecutionNamePrefix { get; set; }

        /// <summary>
        /// StateMachineName
        /// The name of the Step Functions state machine whose execution will be started.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StateMachineName")]
        public Union<string, IntrinsicFunction> StateMachineName { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants IoT permission to start execution of a state machine
        /// (&quot;Action&quot;:&quot;states:StartExecution&quot;).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
