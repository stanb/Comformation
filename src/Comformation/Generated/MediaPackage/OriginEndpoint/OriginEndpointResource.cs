using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-originendpoint.html
    /// </summary>
    public class OriginEndpointResource : ResourceBase
    {
        public class OriginEndpointProperties
        {
            /// <summary>
            /// Id
            /// The manifest ID is required and must be unique within the OriginEndpoint. The ID can&#39;t be changed
            /// after the endpoint is created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Id { get; set; }

            /// <summary>
            /// ChannelId
            /// The ID of the channel associated with this endpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ChannelId { get; set; }

            /// <summary>
            /// Description
            /// Any descriptive information that you want to add to the endpoint for future identification purposes.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Whitelist
            /// The IP addresses that can access this endpoint.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Whitelist { get; set; }

            /// <summary>
            /// StartoverWindowSeconds
            /// Maximum duration (seconds) of content to retain for startover playback. Omit this attribute or enter
            /// 0 to indicate that startover playback is disabled for this endpoint.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> StartoverWindowSeconds { get; set; }

            /// <summary>
            /// TimeDelaySeconds
            /// Minimum duration (seconds) of delay to enforce on the playback of live content. Omit this attribute
            /// or enter 0 to indicate that there is no time delay in effect for this endpoint
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> TimeDelaySeconds { get; set; }

            /// <summary>
            /// ManifestName
            /// A short string that&#39;s appended to the end of the endpoint URL to create a unique path to this
            /// endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ManifestName { get; set; }

            /// <summary>
            /// Origination
            /// Controls video origination from this endpoint.
            /// ALLOW - enables this endpoint to serve content to requesting devices. DENY - prevents this endpoint
            /// from serving content. Denying origination is helpful for harvesting live-to-VOD assets. For more
            /// information about harvesting and origination, see Live-to-VOD Requirements.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Origination { get; set; }

            /// <summary>
            /// Authorization
            /// Parameters for CDN authorization.
            /// Required: No
            /// Type: Authorization
            /// Update requires: No interruption
            /// </summary>
            public Authorization Authorization { get; set; }

            /// <summary>
            /// HlsPackage
            /// Parameters for Apple HLS packaging.
            /// Required: No
            /// Type: HlsPackage
            /// Update requires: No interruption
            /// </summary>
            public HlsPackage HlsPackage { get; set; }

            /// <summary>
            /// DashPackage
            /// Parameters for DASH packaging.
            /// Required: No
            /// Type: DashPackage
            /// Update requires: No interruption
            /// </summary>
            public DashPackage DashPackage { get; set; }

            /// <summary>
            /// MssPackage
            /// Parameters for Microsoft Smooth Streaming packaging.
            /// Required: No
            /// Type: MssPackage
            /// Update requires: No interruption
            /// </summary>
            public MssPackage MssPackage { get; set; }

            /// <summary>
            /// CmafPackage
            /// Parameters for Common Media Application Format (CMAF) packaging.
            /// Required: No
            /// Type: CmafPackage
            /// Update requires: No interruption
            /// </summary>
            public CmafPackage CmafPackage { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the endpoint.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::MediaPackage::OriginEndpoint";

        public OriginEndpointProperties Properties { get; } = new OriginEndpointProperties();

    }

    public static class OriginEndpointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Url = new ResourceAttribute<Union<string, IntrinsicFunction>>("Url");
    }
}
