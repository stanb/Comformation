using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.PrimaryTaskSet
{
    /// <summary>
    /// AWS::ECS::PrimaryTaskSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-primarytaskset.html
    /// </summary>
    public class PrimaryTaskSetResource : ResourceBase
    {
        public class PrimaryTaskSetProperties
        {
            /// <summary>
            /// Cluster
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service that the
            /// task 			set exists in.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Cluster { get; set; }

            /// <summary>
            /// TaskSetId
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the task set to set as the primary task set in
            /// the 			deployment.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TaskSetId { get; set; }

            /// <summary>
            /// Service
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the service that the task set exists in.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Service { get; set; }

        }

        public string Type { get; } = "AWS::ECS::PrimaryTaskSet";

        public PrimaryTaskSetProperties Properties { get; } = new PrimaryTaskSetProperties();

    }
}
