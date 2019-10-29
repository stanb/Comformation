using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition TaskDefinitionPlacementConstraint
    /// The TaskDefinitionPlacementConstraint property specifies an object representing a constraint on task placement
    /// in the task definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-taskdefinitionplacementconstraint.html
    /// </summary>
    public class TaskDefinitionPlacementConstraint
    {

        /// <summary>
        /// Expression
        /// A cluster query language expression to apply to the constraint. For more information, see Cluster
        /// Query Language in the Amazon Elastic Container Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Type
        /// The type of constraint. The MemberOf constraint restricts selection to be from a group of valid
        /// candidates.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: memberOf
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
