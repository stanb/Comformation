using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTThingsGraph.FlowTemplate
{
    /// <summary>
    /// AWS::IoTThingsGraph::FlowTemplate
    /// Represents a workflow template. Workflows can be created only in the user&#39;s namespace. (The public namespace
    /// contains only entities. ) The workflow can contain only entities in the specified namespace. The workflow is
    /// validated against the entities in the latest version of the user&#39;s namespace unless another namespace version
    /// is specified in the request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotthingsgraph-flowtemplate.html
    /// </summary>
    public class FlowTemplateResource : ResourceBase
    {
        public class FlowTemplateProperties
        {
            /// <summary>
            /// CompatibleNamespaceVersion
            /// The version of the user&#39;s namespace against which the workflow was validated. Use this value in your
            /// system instance.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
			public Union<double, IntrinsicFunction> CompatibleNamespaceVersion { get; set; }

            /// <summary>
            /// Definition
            /// A workflow&#39;s definition document.
            /// Required: Yes
            /// Type: DefinitionDocument
            /// Update requires: No interruption
            /// </summary>
			public DefinitionDocument Definition { get; set; }

        }

        public string Type { get; } = "AWS::IoTThingsGraph::FlowTemplate";

        public FlowTemplateProperties Properties { get; } = new FlowTemplateProperties();

    }
}
