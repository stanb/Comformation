using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Amazon CloudWatch Events Rule EcsParameters
    /// The EcsParameters property type specifies information about an Amazon Elastic Container Service (Amazon ECS)
    /// task target.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html
    /// </summary>
    public class EcsParameters
    {

        /// <summary>
        /// TaskCount
        /// The number of tasks to create based on the task definition. The default is 1.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskCount")]
        public Union<int, IntrinsicFunction> TaskCount { get; set; }

        /// <summary>
        /// TaskDefinitionArn
        /// The Amazon Resource Name (ARN) of the task definition to use.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskDefinitionArn")]
        public Union<string, IntrinsicFunction> TaskDefinitionArn { get; set; }

    }
}
