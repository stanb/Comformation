using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.PlaceIndex
{
    /// <summary>
    /// AWS::Location::PlaceIndex
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html
    /// </summary>
    public class PlaceIndexResource : ResourceBase
    {
        public class PlaceIndexProperties
        {
            /// <summary>
            /// DataSource
            /// Specifies the data provider of geospatial data.
            /// Note This field is case-sensitive. Enter the valid values as shown. For example, entering HERE will
            /// return an error.
            /// Valid values include:
            /// Esri Here Important Place index resources using HERE as a data provider can&#39;t be used to store
            /// results for locations in Japan. For more information, see the AWS Service Terms for Amazon Location
            /// Service.
            /// For additional details on data providers, see the Amazon Location Service data providers page.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DataSource { get; set; }

            /// <summary>
            /// DataSourceConfiguration
            /// Specifies the data storage option for requesting Places.
            /// Required: No
            /// Type: DataSourceConfiguration
            /// Update requires: Replacement
            /// </summary>
            public DataSourceConfiguration DataSourceConfiguration { get; set; }

            /// <summary>
            /// Description
            /// The optional description for the place index resource.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1000
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// IndexName
            /// The name of the place index resource.
            /// Requirements:
            /// Contain only alphanumeric characters (A–Z, a–z, 0–9), hyphens (-), periods (. ), and underscores
            /// (_). Must be a unique place index resource name. No spaces allowed. For example, ExamplePlaceIndex.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[-. _\w]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IndexName { get; set; }

            /// <summary>
            /// PricingPlan
            /// Specifies the pricing plan for your place index resource.
            /// For additional details and restrictions on each pricing plan option, see the Amazon Location Service
            /// pricing page.
            /// Required: Yes
            /// Type: String
            /// Allowed values: MobileAssetManagement | MobileAssetTracking | RequestBasedUsage
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlan { get; set; }

        }

        public string Type { get; } = "AWS::Location::PlaceIndex";

        public PlaceIndexProperties Properties { get; } = new PlaceIndexProperties();

    }

    public static class PlaceIndexAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreateTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IndexArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("IndexArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UpdateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("UpdateTime");
    }
}
