using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration FlowDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html
    /// </summary>
    public class FlowDefinition
    {

        /// <summary>
        /// FlowName
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FlowName")]
        public Union<string, IntrinsicFunction> FlowName { get; set; }

        /// <summary>
        /// Description
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// KmsArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsArn")]
        public Union<string, IntrinsicFunction> KmsArn { get; set; }

        /// <summary>
        /// Tasks
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: List of Task
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tasks")]
        public List<Task> Tasks { get; set; }

        /// <summary>
        /// TriggerConfig
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: TriggerConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TriggerConfig")]
        public TriggerConfig TriggerConfig { get; set; }

        /// <summary>
        /// SourceFlowConfig
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: SourceFlowConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceFlowConfig")]
        public SourceFlowConfig SourceFlowConfig { get; set; }

    }
}
