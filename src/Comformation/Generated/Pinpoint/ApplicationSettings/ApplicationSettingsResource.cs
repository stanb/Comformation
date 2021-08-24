using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.ApplicationSettings
{
    /// <summary>
    /// AWS::Pinpoint::ApplicationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html
    /// </summary>
    public class ApplicationSettingsResource : ResourceBase
    {
        public class ApplicationSettingsProperties
        {
            /// <summary>
            /// QuietTime
            /// The default quiet time for campaigns in the application. Quiet time is a specific time range when
            /// campaigns don&#39;t send messages to endpoints, if all the following conditions are met:
            /// - The EndpointDemographic. Timezone property of the endpoint is set to a valid value.
            /// - The current time in the endpoint&#39;s time zone is later than or equal to the time specified by the
            /// QuietTime. Start property for the application (or a campaign that has custom quiet time settings).
            /// - The current time in the endpoint&#39;s time zone is earlier than or equal to the time specified by the
            /// QuietTime. End property for the application (or a campaign that has custom quiet time settings).
            /// If any of the preceding conditions isn&#39;t met, the endpoint will receive messages from a campaign,
            /// even if quiet time is enabled.
            /// To override the default quiet time settings for a specific campaign, use the Campaign resource to
            /// define a custom quiet time for the campaign.
            /// Required: No
            /// Type: QuietTime
            /// Update requires: No interruption
            /// </summary>
            public QuietTime QuietTime { get; set; }

            /// <summary>
            /// Limits
            /// The default sending limits for campaigns in the application. To override these limits for a specific
            /// campaign, use the Campaign resource to define custom limits for the campaign.
            /// Required: No
            /// Type: Limits
            /// Update requires: No interruption
            /// </summary>
            public Limits Limits { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the Amazon Pinpoint application.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// CampaignHook
            /// The settings for the Lambda function to use by default as a code hook for campaigns in the
            /// application. To override these settings for a specific campaign, use the Campaign resource to define
            /// custom Lambda function settings for the campaign.
            /// Required: No
            /// Type: CampaignHook
            /// Update requires: No interruption
            /// </summary>
            public CampaignHook CampaignHook { get; set; }

            /// <summary>
            /// CloudWatchMetricsEnabled
            /// Specifies whether to enable application-related alarms in Amazon CloudWatch.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> CloudWatchMetricsEnabled { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::ApplicationSettings";

        public ApplicationSettingsProperties Properties { get; } = new ApplicationSettingsProperties();

    }
}
