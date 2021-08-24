using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CE.AnomalyMonitor
{
    /// <summary>
    /// AWS::CE::AnomalyMonitor
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalymonitor.html
    /// </summary>
    public class AnomalyMonitorResource : ResourceBase
    {
        public class AnomalyMonitorProperties
        {
            /// <summary>
            /// MonitorType
            /// The possible type values.
            /// Required: Yes
            /// Type: String
            /// Allowed values: CUSTOM | DIMENSIONAL
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MonitorType { get; set; }

            /// <summary>
            /// MonitorName
            /// The name of the monitor.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Pattern: [\S\s]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MonitorName { get; set; }

            /// <summary>
            /// MonitorDimension
            /// The dimensions to evaluate.
            /// Required: No
            /// Type: String
            /// Allowed values: SERVICE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MonitorDimension { get; set; }

            /// <summary>
            /// MonitorSpecification
            /// The array of MonitorSpecification in JSON array format. For instance, you can use
            /// MonitorSpecification to specify a tag, Cost Category, or linked account for your custom anomaly
            /// monitor. For further information, see the Examples section of this page.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MonitorSpecification { get; set; }

        }

        public string Type { get; } = "AWS::CE::AnomalyMonitor";

        public AnomalyMonitorProperties Properties { get; } = new AnomalyMonitorProperties();

    }

    public static class AnomalyMonitorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MonitorArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("MonitorArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationDate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastEvaluatedDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastEvaluatedDate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedDate");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> DimensionalValueCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("DimensionalValueCount");
    }
}
