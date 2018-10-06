using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger
    /// The AWS::Glue::Trigger resource specifies triggers that run AWS Glue jobs. For more information, see
    /// Triggering Jobs in AWS Glue and Trigger Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html
    /// </summary>
    public class TriggerResource : ResourceBase
    {
        public class TriggerProperties
        {
            /// <summary>
            /// Type
            /// The type of job trigger. Valid values are SCHEDULED, CONDITIONAL, or ON_DEMAND.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// The description of the job trigger.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Actions
            /// The actions that the job trigger initiates when it fires.
            /// Required: Yes
            /// Type: List of AWS Glue Trigger Action
            /// Update requires: No interruption
            /// </summary>
			public List<Action> Actions { get; set; }

            /// <summary>
            /// Schedule
            /// The cron schedule expression for the job trigger.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Schedule { get; set; }

            /// <summary>
            /// Name
            /// The name of the job trigger.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Predicate
            /// The predicate of the job trigger, which determines when the trigger fires.
            /// Required: No
            /// Type: AWS Glue Trigger Predicate
            /// Update requires: No interruption
            /// </summary>
			public Predicate Predicate { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Trigger";
        
        public TriggerProperties Properties { get; } = new TriggerProperties();

    }
}
