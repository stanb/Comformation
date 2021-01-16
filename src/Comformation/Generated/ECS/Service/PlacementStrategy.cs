using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service PlacementStrategy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementstrategy.html
    /// </summary>
    public class PlacementStrategy
    {

        /// <summary>
        /// Field
        /// 		
        /// The field to apply the placement strategy against. For the spread 			placement strategy, valid
        /// values are instanceId (or host, 			which has the same effect), or any platform or custom attribute
        /// that is applied to a 			container instance, such as attribute:ecs. availability-zone. For the
        /// 				binpack placement strategy, valid values are cpu and 				memory. For the random placement
        /// strategy, this field is 			not used.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Field")]
        public Union<string, IntrinsicFunction> Field { get; set; }

        /// <summary>
        /// Type
        /// 		
        /// The type of placement strategy. The random placement strategy randomly 			places tasks on available
        /// candidates. The spread placement strategy spreads 			placement across available candidates evenly
        /// based on the field parameter. 			The binpack strategy places tasks on available candidates that have
        /// the 			least available amount of the resource that is specified with the field 			parameter. For
        /// example, if you binpack on memory, a task is placed on the instance with 			the least amount of
        /// remaining memory (but still enough to run the task).
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: binpack | random | spread
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
