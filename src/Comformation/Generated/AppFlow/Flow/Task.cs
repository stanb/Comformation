using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow Task
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html
    /// </summary>
    public class Task
    {

        /// <summary>
        /// SourceFields
        /// The source fields to which a particular task is applied.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceFields")]
        public List<Union<string, IntrinsicFunction>> SourceFields { get; set; }

        /// <summary>
        /// ConnectorOperator
        /// The operation to be performed on the provided source fields.
        /// Required: No
        /// Type: ConnectorOperator
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectorOperator")]
        public ConnectorOperator ConnectorOperator { get; set; }

        /// <summary>
        /// DestinationField
        /// A field in a destination connector, or a field value against which Amazon AppFlow validates a source
        /// field.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationField")]
        public Union<string, IntrinsicFunction> DestinationField { get; set; }

        /// <summary>
        /// TaskType
        /// Specifies the particular task implementation that Amazon AppFlow performs.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Arithmetic | Filter | Map | Mask | Merge | Truncate | Validate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskType")]
        public Union<string, IntrinsicFunction> TaskType { get; set; }

        /// <summary>
        /// TaskProperties
        /// A map used to store task-related information. The execution service looks for particular information
        /// based on the TaskType.
        /// Required: No
        /// Type: List of TaskPropertiesObject
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskProperties")]
        public List<TaskPropertiesObject> TaskProperties { get; set; }

    }
}
