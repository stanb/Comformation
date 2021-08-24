using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration Task
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-task.html
    /// </summary>
    public class Task
    {

        /// <summary>
        /// ConnectorOperator
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: ConnectorOperator
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorOperator")]
        public ConnectorOperator ConnectorOperator { get; set; }

        /// <summary>
        /// SourceFields
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceFields")]
        public List<Union<string, IntrinsicFunction>> SourceFields { get; set; }

        /// <summary>
        /// DestinationField
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationField")]
        public Union<string, IntrinsicFunction> DestinationField { get; set; }

        /// <summary>
        /// TaskType
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskType")]
        public Union<string, IntrinsicFunction> TaskType { get; set; }

        /// <summary>
        /// TaskProperties
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of TaskPropertiesMap
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskProperties")]
        public List<TaskPropertiesMap> TaskProperties { get; set; }

    }
}
