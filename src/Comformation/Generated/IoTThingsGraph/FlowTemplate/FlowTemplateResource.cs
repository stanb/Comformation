using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTThingsGraph.FlowTemplate
{
    /// <summary>
    /// AWS::IoTThingsGraph::FlowTemplate
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
