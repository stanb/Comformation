using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.Tracker
{
    /// <summary>
    /// AWS::Location::Tracker
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-tracker.html
    /// </summary>
    public class TrackerResource : ResourceBase
    {
        public class TrackerProperties
        {
            /// <summary>
            /// Description
            /// An optional description for the tracker resource.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1000
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// KmsKeyId
            /// A key identifier for an AWS KMS customer managed key. Enter a key ID, key ARN, alias name, or alias
            /// ARN.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// PricingPlan
            /// Specifies the pricing plan for the tracker resource.
            /// For additional details and restrictions on each pricing plan option, see the Amazon Location Service
            /// pricing page.
            /// Required: Yes
            /// Type: String
            /// Allowed values: MobileAssetManagement | MobileAssetTracking | RequestBasedUsage
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlan { get; set; }

            /// <summary>
            /// PricingPlanDataSource
            /// Specifies the data provider for the tracker resource.
            /// Required value for the following pricing plans: MobileAssetTracking | MobileAssetManagement
            /// For more information about Data Providers, and Pricing plans, see the Amazon Location Service
            /// product page.
            /// Note Amazon Location Service only uses PricingPlanDataSource to calculate billing for your tracker
            /// resource. Your data will not be shared with the data provider, and will remain in your AWS account
            /// or region unless you move it.
            /// Valid Values: Esri | Here
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlanDataSource { get; set; }

            /// <summary>
            /// TrackerName
            /// The name for the tracker resource.
            /// Requirements:
            /// Contain only alphanumeric characters (A-Z, a-z, 0-9) , hyphens (-), periods (. ), and underscores
            /// (_). Must be a unique tracker resource name. No spaces allowed. For example, ExampleTracker.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[-. _\w]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TrackerName { get; set; }

        }

        public string Type { get; } = "AWS::Location::Tracker";

        public TrackerProperties Properties { get; } = new TrackerProperties();

    }

    public static class TrackerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreateTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TrackerArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TrackerArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UpdateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("UpdateTime");
    }
}
