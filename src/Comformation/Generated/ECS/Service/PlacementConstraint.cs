using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service PlacementConstraint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementconstraint.html
    /// </summary>
    public class PlacementConstraint
    {

        /// <summary>
        /// Expression
        /// 		
        /// A cluster query language expression to apply to the constraint. You cannot specify an 			expression
        /// if the constraint type is distinctInstance. For more 			information, see Cluster Query Language in
        /// the 				Amazon Elastic Container Service Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Type
        /// 		
        /// The type of constraint. Use distinctInstance to ensure that each task in 			a particular group is
        /// running on a different container instance. Use 				memberOf to restrict the selection to a group of
        /// valid 			candidates.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: distinctInstance | memberOf
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
