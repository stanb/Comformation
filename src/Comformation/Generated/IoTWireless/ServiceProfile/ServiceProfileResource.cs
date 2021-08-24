using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.ServiceProfile
{
    /// <summary>
    /// AWS::IoTWireless::ServiceProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-serviceprofile.html
    /// </summary>
    public class ServiceProfileResource : ResourceBase
    {
        public class ServiceProfileProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the new resource. The maximum length is 256 characters.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// LoRaWAN
            /// LoRaWANServiceProfile object.
            /// Required: No
            /// Type: LoRaWANServiceProfile
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANServiceProfile LoRaWAN { get; set; }

            /// <summary>
            /// Tags
            /// 		 		
            /// An array of key-value pairs to apply to this resource. Tags can have a minimum of 0 and a maximum of
            /// 50 items.
            /// 		
            /// For more information, see Tag.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::ServiceProfile";

        public ServiceProfileProperties Properties { get; } = new ServiceProfileProperties();

    }

    public static class ServiceProfileAttributes
    {
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_UlRate = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "UlRate");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_UlBucketSize = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "UlBucketSize");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoRaWAN_UlRatePolicy = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoRaWAN", "UlRatePolicy");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_DlRate = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "DlRate");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_DlBucketSize = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "DlBucketSize");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoRaWAN_DlRatePolicy = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoRaWAN", "DlRatePolicy");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_DevStatusReqFreq = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "DevStatusReqFreq");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> LoRaWAN_ReportDevStatusBattery = new ResourceAttribute<Union<bool, IntrinsicFunction>>("LoRaWAN", "ReportDevStatusBattery");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> LoRaWAN_ReportDevStatusMargin = new ResourceAttribute<Union<bool, IntrinsicFunction>>("LoRaWAN", "ReportDevStatusMargin");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_DrMin = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "DrMin");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_DrMax = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "DrMax");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoRaWAN_ChannelMask = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoRaWAN", "ChannelMask");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> LoRaWAN_PrAllowed = new ResourceAttribute<Union<bool, IntrinsicFunction>>("LoRaWAN", "PrAllowed");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> LoRaWAN_HrAllowed = new ResourceAttribute<Union<bool, IntrinsicFunction>>("LoRaWAN", "HrAllowed");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> LoRaWAN_RaAllowed = new ResourceAttribute<Union<bool, IntrinsicFunction>>("LoRaWAN", "RaAllowed");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> LoRaWAN_NwkGeoLoc = new ResourceAttribute<Union<bool, IntrinsicFunction>>("LoRaWAN", "NwkGeoLoc");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_TargetPer = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "TargetPer");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> LoRaWAN_MinGwDiversity = new ResourceAttribute<Union<int, IntrinsicFunction>>("LoRaWAN", "MinGwDiversity");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
