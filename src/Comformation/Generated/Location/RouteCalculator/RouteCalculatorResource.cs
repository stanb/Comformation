using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Location.RouteCalculator
{
    /// <summary>
    /// AWS::Location::RouteCalculator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-routecalculator.html
    /// </summary>
    public class RouteCalculatorResource : ResourceBase
    {
        public class RouteCalculatorProperties
        {
            /// <summary>
            /// CalculatorName
            /// The name of the route calculator resource.
            /// Requirements:
            /// Can use alphanumeric characters (A–Z, a–z, 0–9) , hyphens (-), periods (. ), and underscores (_).
            /// Must be a unique route calculator resource name. No spaces allowed. For example,
            /// ExampleRouteCalculator.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[-. _\w]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CalculatorName { get; set; }

            /// <summary>
            /// DataSource
            /// Specifies the data provider of traffic and road network data.
            /// Note This field is case-sensitive. Enter the valid values as shown. For example, entering HERE
            /// returns an error.
            /// Valid values include:
            /// Esri Here
            /// For more information about data providers, see the Amazon Location Service data providers page.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DataSource { get; set; }

            /// <summary>
            /// Description
            /// The optional description for the route calculator resource.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1000
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// PricingPlan
            /// Specifies the pricing plan for your route calculator resource.
            /// For additional details and restrictions on each pricing plan option, see the Amazon Location Service
            /// pricing page.
            /// Required: Yes
            /// Type: String
            /// Allowed values: MobileAssetManagement | MobileAssetTracking | RequestBasedUsage
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PricingPlan { get; set; }

        }

        public string Type { get; } = "AWS::Location::RouteCalculator";

        public RouteCalculatorProperties Properties { get; } = new RouteCalculatorProperties();

    }

    public static class RouteCalculatorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CalculatorArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CalculatorArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreateTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> UpdateTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("UpdateTime");
    }
}
