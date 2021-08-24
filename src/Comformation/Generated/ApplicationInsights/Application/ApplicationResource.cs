using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationinsights-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ResourceGroupName
            /// The name of the resource group used for the application.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [a-zA-Z0-9\. \-_]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceGroupName { get; set; }

            /// <summary>
            /// CWEMonitorEnabled
            /// Indicates whether Application Insights can listen to CloudWatch events for the application
            /// resources, such as instance terminated, failed deployment, and others.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> CWEMonitorEnabled { get; set; }

            /// <summary>
            /// OpsCenterEnabled
            /// Indicates whether Application Insights will create OpsItems for any problem that is detected by
            /// Application Insights for an application.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> OpsCenterEnabled { get; set; }

            /// <summary>
            /// OpsItemSNSTopicArn
            /// The SNS topic provided to Application Insights that is associated with the created OpsItems to
            /// receive SNS notifications for opsItem updates.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 300
            /// Pattern: ^arn:aws(-\w+)*:[\w\d-]+:([\w\d-]*)?:[\w\d_-]*([:/]. +)*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> OpsItemSNSTopicArn { get; set; }

            /// <summary>
            /// Tags
            /// An array of Tags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// CustomComponents
            /// Describes a custom component by grouping similar standalone instances to monitor.
            /// Required: No
            /// Type: List of CustomComponent
            /// Update requires: No interruption
            /// </summary>
            public List<CustomComponent> CustomComponents { get; set; }

            /// <summary>
            /// LogPatternSets
            /// The log pattern sets.
            /// Required: No
            /// Type: List of LogPatternSet
            /// Update requires: No interruption
            /// </summary>
            public List<LogPatternSet> LogPatternSets { get; set; }

            /// <summary>
            /// AutoConfigurationEnabled
            /// If set to true, the application components will be configured with the monitoring configuration
            /// recommended by Application Insights.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoConfigurationEnabled { get; set; }

            /// <summary>
            /// ComponentMonitoringSettings
            /// The monitoring settings of the components.
            /// Required: No
            /// Type: List of ComponentMonitoringSetting
            /// Update requires: No interruption
            /// </summary>
            public List<ComponentMonitoringSetting> ComponentMonitoringSettings { get; set; }

        }

        public string Type { get; } = "AWS::ApplicationInsights::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }

    public static class ApplicationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApplicationARN = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApplicationARN");
    }
}
