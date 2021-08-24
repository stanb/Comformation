using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ResponsePlan
{
    /// <summary>
    /// AWS::SSMIncidents::ResponsePlan IncidentTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-incidenttemplate.html
    /// </summary>
    public class IncidentTemplate
    {

        /// <summary>
        /// DedupeString
        /// Used to create only one incident record for an incident.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DedupeString")]
        public Union<string, IntrinsicFunction> DedupeString { get; set; }

        /// <summary>
        /// Impact
        /// Defines the impact to the customers. Providing an impact overwrites the impact provided by a
        /// response plan.
        /// Possible impacts: 1 - Critical impact, this typically relates to full application failure that
        /// impacts many to all customers. 2 - High impact, partial application failure with impact to many
        /// customers. 3 - Medium impact, the application is providing reduced service to customers. 4 - Low
        /// impact, customer might aren&#39;t impacted by the problem yet. 5 - No impact, customers aren&#39;t currently
        /// impacted but urgent action is needed to avoid impact.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Impact")]
        public Union<int, IntrinsicFunction> Impact { get; set; }

        /// <summary>
        /// NotificationTargets
        /// The SNS targets that AWS Chatbot uses to notify the chat channel of updates to an incident. You can
        /// also make updates to the incident through the chat channel using the SNS topics.
        /// Required: No
        /// Type: List of NotificationTargetItem
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationTargets")]
        public List<NotificationTargetItem> NotificationTargets { get; set; }

        /// <summary>
        /// Summary
        /// The summary describes what has happened during the incident.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 4000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Summary")]
        public Union<string, IntrinsicFunction> Summary { get; set; }

        /// <summary>
        /// Title
        /// The title of the incident is a brief and easily recognizable.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 200
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Title")]
        public Union<string, IntrinsicFunction> Title { get; set; }

    }
}
