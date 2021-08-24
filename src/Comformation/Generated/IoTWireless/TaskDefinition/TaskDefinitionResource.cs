using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.TaskDefinition
{
    /// <summary>
    /// AWS::IoTWireless::TaskDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-taskdefinition.html
    /// </summary>
    public class TaskDefinitionResource : ResourceBase
    {
        public class TaskDefinitionProperties
        {
            /// <summary>
            /// Name
            /// The name of the new resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// AutoCreateTasks
            /// Whether to automatically create tasks using this task definition for all gateways with the specified
            /// current version. If false, the task must me created by calling CreateWirelessGatewayTask.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoCreateTasks { get; set; }

            /// <summary>
            /// Update
            /// Information about the gateways to update.
            /// Required: No
            /// Type: UpdateWirelessGatewayTaskCreate
            /// Update requires: No interruption
            /// </summary>
            public UpdateWirelessGatewayTaskCreate Update { get; set; }

            /// <summary>
            /// LoRaWANUpdateGatewayTaskEntry
            /// </summary>
            public LoRaWANUpdateGatewayTaskEntry LoRaWANUpdateGatewayTaskEntry { get; set; }

            /// <summary>
            /// TaskDefinitionType
            /// </summary>
            public Union<string, IntrinsicFunction> TaskDefinitionType { get; set; }

            /// <summary>
            /// Tags
            /// The tags to attach to the specified resource. Tags are metadata that you can use to manage a
            /// resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::TaskDefinition";

        public TaskDefinitionProperties Properties { get; } = new TaskDefinitionProperties();

    }

    public static class TaskDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
