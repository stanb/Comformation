using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service Service PlacementConstraint
    /// PlacementConstraint is a property of the AWS::ECS::Service resource that specifies the placement constraints
    /// for the tasks in the service to associate with an Amazon Elastic Container Service (Amazon ECS) service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-placementconstraints-taskdefinitionplacementconstraint.html
    /// </summary>
    public class TaskDefinitionPlacementConstraint
    {

        /// <summary>
        /// Expression
        /// A cluster query language expression to apply to the constraint. If the constraint type is
        /// distinctInstance, you can't specify an expression. For more information, see Cluster Query Language
        /// in the Amazon Elastic Container Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Type
        /// The type of constraint: distinctInstance or memberOf.
        /// To ensure that each task in a particular group is running on a different container instance, use
        /// distinctInstance. To restrict selection to a group of valid candidates, use memberOf.
        /// distinctInstance is not supported in task definitions.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
