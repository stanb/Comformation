using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html
    /// </summary>
    public class CampaignResource : ResourceBase
    {
        public class CampaignProperties
        {
            /// <summary>
            /// Description
            /// A custom description of the campaign.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// SegmentId
            /// The unique identifier for the segment to associate with the campaign.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SegmentId { get; set; }

            /// <summary>
            /// IsPaused
            /// Specifies whether to pause the campaign. A paused campaign doesn&#39;t run unless you resume it by
            /// changing this value to false. If you restart a campaign, the campaign restarts from the beginning
            /// and not at the point you paused it.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> IsPaused { get; set; }

            /// <summary>
            /// AdditionalTreatments
            /// An array of requests that defines additional treatments for the campaign, in addition to the default
            /// treatment for the campaign.
            /// Required: No
            /// Type: List of WriteTreatmentResource
            /// Update requires: No interruption
            /// </summary>
            public List<WriteTreatmentResource> AdditionalTreatments { get; set; }

            /// <summary>
            /// Name
            /// The name of the campaign.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SegmentVersion
            /// The version of the segment to associate with the campaign.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> SegmentVersion { get; set; }

            /// <summary>
            /// TreatmentDescription
            /// A custom description of the default treatment for the campaign.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TreatmentDescription { get; set; }

            /// <summary>
            /// MessageConfiguration
            /// The message configuration settings for the campaign.
            /// Required: Yes
            /// Type: MessageConfiguration
            /// Update requires: No interruption
            /// </summary>
            public MessageConfiguration MessageConfiguration { get; set; }

            /// <summary>
            /// Limits
            /// The messaging limits for the campaign.
            /// Required: No
            /// Type: Limits
            /// Update requires: No interruption
            /// </summary>
            public Limits Limits { get; set; }

            /// <summary>
            /// HoldoutPercent
            /// The allocated percentage of users (segment members) who shouldn&#39;t receive messages from the
            /// campaign.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HoldoutPercent { get; set; }

            /// <summary>
            /// Schedule
            /// The schedule settings for the campaign.
            /// Required: Yes
            /// Type: Schedule
            /// Update requires: No interruption
            /// </summary>
            public Schedule Schedule { get; set; }

            /// <summary>
            /// ApplicationId
            /// The unique identifier for the Amazon Pinpoint application that the campaign is associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// CampaignHook
            /// Specifies the AWS Lambda function to use as a code hook for a campaign.
            /// Required: No
            /// Type: CampaignHook
            /// Update requires: No interruption
            /// </summary>
            public CampaignHook CampaignHook { get; set; }

            /// <summary>
            /// Tags
            /// A string-to-string map of key-value pairs that defines the tags to associate with the campaign. Each
            /// tag consists of a required tag key and an associated tag value.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// TreatmentName
            /// A custom name of the default treatment for the campaign, if the campaign has multiple treatments. A
            /// treatment is a variation of a campaign that&#39;s used for A/B testing.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TreatmentName { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::Campaign";

        public CampaignProperties Properties { get; } = new CampaignProperties();

    }

    public static class CampaignAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CampaignId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CampaignId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
