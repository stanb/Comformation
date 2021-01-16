using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowEntitlement
{
    /// <summary>
    /// AWS::MediaConnect::FlowEntitlement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowentitlement.html
    /// </summary>
    public class FlowEntitlementResource : ResourceBase
    {
        public class FlowEntitlementProperties
        {
            /// <summary>
            /// FlowArn
            /// The Amazon Resource Name (ARN) of the flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FlowArn { get; set; }

            /// <summary>
            /// DataTransferSubscriberFeePercent
            /// The percentage of the entitlement data transfer fee that you want the subscriber to be responsible
            /// for.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> DataTransferSubscriberFeePercent { get; set; }

            /// <summary>
            /// Description
            /// A description of the entitlement. This description appears only on the MediaConnect console and is
            /// not visible outside of the current AWS account.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Encryption
            /// The type of encryption that MediaConnect will use on the output that is associated with the
            /// entitlement.
            /// Required: No
            /// Type: Encryption
            /// Update requires: No interruption
            /// </summary>
            public Encryption Encryption { get; set; }

            /// <summary>
            /// EntitlementStatus
            /// An indication of whether the new entitlement should be enabled or disabled as soon as it is created.
            /// If you don’t specify the entitlementStatus field in your request, MediaConnect sets it to ENABLED.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EntitlementStatus { get; set; }

            /// <summary>
            /// Name
            /// The name of the entitlement. This value must be unique within the current flow.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Subscribers
            /// The AWS account IDs that you want to share your content with. The receiving accounts (subscribers)
            /// will be allowed to create their own flows using your content as the source.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Subscribers { get; set; }

        }

        public string Type { get; } = "AWS::MediaConnect::FlowEntitlement";

        public FlowEntitlementProperties Properties { get; } = new FlowEntitlementProperties();

    }

    public static class FlowEntitlementAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EntitlementArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("EntitlementArn");
    }
}
