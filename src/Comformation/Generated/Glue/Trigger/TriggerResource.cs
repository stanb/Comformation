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
            /// The type of trigger that this is.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// A description of this trigger.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Actions
            /// The actions initiated by this trigger.
            /// Required: Yes
            /// Type: List of Action
            /// Update requires: No interruption
            /// </summary>
			public List<Action> Actions { get; set; }

            /// <summary>
            /// Schedule
            /// A cron expression used to specify the schedule (see Time-Based Schedules for Jobs and Crawlers. For
            /// example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Schedule { get; set; }

            /// <summary>
            /// Name
            /// The name of the trigger.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Predicate
            /// The predicate of this trigger, which defines when it will fire.
            /// Required: No
            /// Type: Predicate
            /// Update requires: No interruption
            /// </summary>
			public Predicate Predicate { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Trigger";

        public TriggerProperties Properties { get; } = new TriggerProperties();

    }
}
