using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger
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
            /// StartOnCreation
            /// Set to true to start SCHEDULED and CONDITIONAL triggers when created. True is not supported for
            /// ON_DEMAND triggers.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> StartOnCreation { get; set; }

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
            /// WorkflowName
            /// The name of the workflow associated with the trigger.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkflowName { get; set; }

            /// <summary>
            /// Schedule
            /// A cron expression used to specify the schedule. For more information, see Time-Based Schedules for
            /// Jobs and Crawlers in the AWS Glue Developer Guide. For example, to run something every day at 12:15
            /// UTC, specify cron(15 12 * * ? *).
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Schedule { get; set; }

            /// <summary>
            /// Tags
            /// The tags to use with this trigger.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

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
