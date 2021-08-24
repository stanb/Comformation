using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.Site
{
    /// <summary>
    /// AWS::NetworkManager::Site
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-site.html
    /// </summary>
    public class SiteResource : ResourceBase
    {
        public class SiteProperties
        {
            /// <summary>
            /// Description
            /// A description of your site.
            /// Constraints: Maximum length of 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the site.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// GlobalNetworkId
            /// The ID of the global network.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalNetworkId { get; set; }

            /// <summary>
            /// Location
            /// The site location. This information is used for visualization in the Network Manager console. If you
            /// specify the address, the latitude and longitude are automatically calculated.
            /// Address: The physical address of the site. Latitude: The latitude of the site. Longitude: The
            /// longitude of the site.
            /// Required: No
            /// Type: Location
            /// Update requires: No interruption
            /// </summary>
            public Location Location { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::Site";

        public SiteProperties Properties { get; } = new SiteProperties();

    }

    public static class SiteAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SiteArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SiteArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SiteId = new ResourceAttribute<Union<string, IntrinsicFunction>>("SiteId");
    }
}
