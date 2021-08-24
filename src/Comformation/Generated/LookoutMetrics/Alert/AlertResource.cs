using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutMetrics.Alert
{
    /// <summary>
    /// AWS::LookoutMetrics::Alert
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutmetrics-alert.html
    /// </summary>
    public class AlertResource : ResourceBase
    {
        public class AlertProperties
        {
            /// <summary>
            /// AlertName
            /// The name of the alert.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AlertName { get; set; }

            /// <summary>
            /// AlertDescription
            /// A description of the alert.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AlertDescription { get; set; }

            /// <summary>
            /// AnomalyDetectorArn
            /// The ARN of the detector to which the alert is attached.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AnomalyDetectorArn { get; set; }

            /// <summary>
            /// AlertSensitivityThreshold
            /// An integer from 0 to 100 specifying the alert sensitivity threshold.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> AlertSensitivityThreshold { get; set; }

            /// <summary>
            /// Action
            /// Action that will be triggered when there is an alert.
            /// Required: Yes
            /// Type: Action
            /// Update requires: Replacement
            /// </summary>
            public Action Action { get; set; }

        }

        public string Type { get; } = "AWS::LookoutMetrics::Alert";

        public AlertProperties Properties { get; } = new AlertProperties();

    }

    public static class AlertAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
