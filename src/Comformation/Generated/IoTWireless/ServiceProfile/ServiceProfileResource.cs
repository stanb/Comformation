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
            /// The name of the new resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// LoRaWANServiceProfile
            /// LoRaWANServiceProfile object.
            /// Required: No
            /// Type: LoRaWANServiceProfile
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANServiceProfile LoRaWANServiceProfile { get; set; }

            /// <summary>
            /// LoRaWANGetServiceProfileInfo
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: LoRaWANGetServiceProfileInfo
            /// Update requires: No interruption
            /// </summary>
            public LoRaWANGetServiceProfileInfo LoRaWANGetServiceProfileInfo { get; set; }

            /// <summary>
            /// Tags
            /// 		 		
            /// An array of key-value pairs to apply to this resource.
            /// 		
            /// For more information, see Tag.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// NextToken
            /// 		
            /// This parameter isn&#39;t needed to create this resource. Do not include it in your template.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NextToken { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::ServiceProfile";

        public ServiceProfileProperties Properties { get; } = new ServiceProfileProperties();

    }

    public static class ServiceProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
