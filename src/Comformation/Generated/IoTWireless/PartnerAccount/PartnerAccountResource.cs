using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.PartnerAccount
{
    /// <summary>
    /// AWS::IoTWireless::PartnerAccount
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html
    /// </summary>
    public class PartnerAccountResource : ResourceBase
    {
        public class PartnerAccountProperties
        {
            /// <summary>
            /// Sidewalk
            /// The Sidewalk account credentials.
            /// Required: No
            /// Type: SidewalkAccountInfo
            /// Update requires: No interruption
            /// </summary>
            public SidewalkAccountInfo Sidewalk { get; set; }

            /// <summary>
            /// PartnerAccountId
            /// The ID of the partner account to update.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PartnerAccountId { get; set; }

            /// <summary>
            /// PartnerType
            /// </summary>
            public Union<string, IntrinsicFunction> PartnerType { get; set; }

            /// <summary>
            /// AccountLinked
            /// </summary>
            public Union<bool, IntrinsicFunction> AccountLinked { get; set; }

            /// <summary>
            /// SidewalkUpdate
            /// </summary>
            public SidewalkUpdateAccount SidewalkUpdate { get; set; }

            /// <summary>
            /// Fingerprint
            /// </summary>
            public Union<string, IntrinsicFunction> Fingerprint { get; set; }

            /// <summary>
            /// Tags
            /// The tags to attach to the specified resource. Tags are metadata that you can use to manage a
            /// resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoTWireless::PartnerAccount";

        public PartnerAccountProperties Properties { get; } = new PartnerAccountProperties();

    }

    public static class PartnerAccountAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
