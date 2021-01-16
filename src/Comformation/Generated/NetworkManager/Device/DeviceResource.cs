using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.Device
{
    /// <summary>
    /// AWS::NetworkManager::Device
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-device.html
    /// </summary>
    public class DeviceResource : ResourceBase
    {
        public class DeviceProperties
        {
            /// <summary>
            /// Description
            /// A description of the device.
            /// Length Constraints: Maximum length of 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the device.
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
            /// The site location.
            /// Required: No
            /// Type: Location
            /// Update requires: No interruption
            /// </summary>
            public Location Location { get; set; }

            /// <summary>
            /// Model
            /// The model of the device.
            /// Length Constraints: Maximum length of 128 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Model { get; set; }

            /// <summary>
            /// SerialNumber
            /// The serial number of the device.
            /// Length Constraints: Maximum length of 128 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SerialNumber { get; set; }

            /// <summary>
            /// SiteId
            /// The site ID.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SiteId { get; set; }

            /// <summary>
            /// Type
            /// The device type.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Vendor
            /// The vendor of the device.
            /// Length Constraints: Maximum length of 128 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Vendor { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::Device";

        public DeviceProperties Properties { get; } = new DeviceProperties();

    }

    public static class DeviceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DeviceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DeviceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DeviceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DeviceId");
    }
}
