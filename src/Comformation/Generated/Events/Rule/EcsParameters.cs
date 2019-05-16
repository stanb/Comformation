using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule EcsParameters
    /// The EcsParameters property type specifies custom parameters to be used when the target is an Amazon ECS task.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html
    /// </summary>
    public class EcsParameters
    {

        /// <summary>
        /// TaskCount
        /// The number of tasks to create based on TaskDefinition. The default is 1.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskCount")]
        public Union<int, IntrinsicFunction> TaskCount { get; set; }

        /// <summary>
        /// TaskDefinitionArn
        /// The ARN of the task definition to use.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskDefinitionArn")]
        public Union<string, IntrinsicFunction> TaskDefinitionArn { get; set; }

    }
}
