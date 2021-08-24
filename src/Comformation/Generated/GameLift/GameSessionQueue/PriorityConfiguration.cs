using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameSessionQueue
{
    /// <summary>
    /// AWS::GameLift::GameSessionQueue PriorityConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html
    /// </summary>
    public class PriorityConfiguration
    {

        /// <summary>
        /// PriorityOrder
        /// The recommended sequence to use when prioritizing where to place new game sessions. Each type can
        /// only be listed once.
        /// LATENCY -- FleetIQ prioritizes locations where the average player latency (provided in each game
        /// session request) is lowest. COST -- FleetIQ prioritizes destinations with the lowest current hosting
        /// costs. Cost is evaluated based on the location, instance type, and fleet type (Spot or On-Demand)
        /// for each destination in the queue. DESTINATION -- FleetIQ prioritizes based on the order that
        /// destinations are listed in the queue configuration. LOCATION -- FleetIQ prioritizes based on the
        /// provided order of locations, as defined in LocationOrder.
        /// Required: No
        /// Type: List of String
        /// Maximum: 4
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PriorityOrder")]
        public List<Union<string, IntrinsicFunction>> PriorityOrder { get; set; }

        /// <summary>
        /// LocationOrder
        /// The prioritization order to use for fleet locations, when the PriorityOrder property includes
        /// LOCATION. Locations are identified by AWS Region codes such as us-west-2. Each location can only be
        /// listed once.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LocationOrder")]
        public List<Union<string, IntrinsicFunction>> LocationOrder { get; set; }

    }
}
