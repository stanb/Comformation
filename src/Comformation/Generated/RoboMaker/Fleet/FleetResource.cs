using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RoboMaker.Fleet
{
    /// <summary>
    /// AWS::RoboMaker::Fleet
    /// The AWS::RoboMaker::Fleet resource creates an AWS RoboMaker fleet. Fleets contain robots and can receive
    /// deployments.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-fleet.html
    /// </summary>
    public class FleetResource : ResourceBase
    {
        public class FleetProperties
        {
            /// <summary>
            /// Tags
            /// The list of all tags added to the fleet.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the fleet.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RoboMaker::Fleet";

        public FleetProperties Properties { get; } = new FleetProperties();

    }

	public static class FleetAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
