using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.GeofenceCollection
{
    /// <summary>
    /// AWS::Location::GeofenceCollection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-geofencecollection.html
    /// </summary>
    public class GeofenceCollectionResource : ResourceBase
    {
        public class GeofenceCollectionProperties
        {
            /// <summary>
            /// CollectionName
            /// The name for the geofence collection.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[-. _\w]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CollectionName { get; set; }

            /// <summary>
            /// Description
            /// An optional description for the geofence collection.
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
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// PricingPlan
            /// Specifies the pricing plan for the geofence collection.
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
            /// Specifies the data provider for the geofence collection.
            /// Required value for the following pricing plans: MobileAssetTracking | MobileAssetManagement
            /// For more information about Data Providers, and Pricing plans, see the Amazon Location Service
            /// product page.
            /// Note Amazon Location Service only uses PricingPlanDataSource to calculate billing for your geofence
            /// collection. Your data will not be shared with the data provider, and will remain in your AWS account
            /// or region unless you move it.
            /// Valid Values: Esri | Here
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlanDataSource { get; set; }

        }

        public string Type { get; } = "AWS::Location::GeofenceCollection";

        public GeofenceCollectionProperties Properties { get; } = new GeofenceCollectionProperties();

    }

    public static class GeofenceCollectionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CollectionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CollectionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreateTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UpdateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("UpdateTime");
    }
}
