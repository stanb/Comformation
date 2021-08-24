using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ResponsePlan
{
    /// <summary>
    /// AWS::SSMIncidents::ResponsePlan
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmincidents-responseplan.html
    /// </summary>
    public class ResponsePlanResource : ResourceBase
    {
        public class ResponsePlanProperties
        {
            /// <summary>
            /// Name
            /// The name of the response plan.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 200
            /// Pattern: ^[a-zA-Z0-9-_]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DisplayName
            /// The human readable name of the response plan.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// ChatChannel
            /// The AWS Chatbot chat channel used for collaboration during an incident.
            /// Required: No
            /// Type: ChatChannel
            /// Update requires: No interruption
            /// </summary>
            public ChatChannel ChatChannel { get; set; }

            /// <summary>
            /// Engagements
            /// The contacts and escalation plans that the response plan engages during an incident.
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Engagements { get; set; }

            /// <summary>
            /// Actions
            /// The actions that the response plan starts at the beginning of an incident.
            /// Required: No
            /// Type: List of Action
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Action> Actions { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// IncidentTemplate
            /// Details used to create an incident when using this response plan.
            /// Required: Yes
            /// Type: IncidentTemplate
            /// Update requires: No interruption
            /// </summary>
            public IncidentTemplate IncidentTemplate { get; set; }

        }

        public string Type { get; } = "AWS::SSMIncidents::ResponsePlan";

        public ResponsePlanProperties Properties { get; } = new ResponsePlanProperties();

    }

    public static class ResponsePlanAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
