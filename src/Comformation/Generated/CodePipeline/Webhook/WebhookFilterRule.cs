using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Webhook
{
    /// <summary>
    /// AWS::CodePipeline::Webhook WebhookFilterRule
    /// The event criteria that specify when a webhook notification is sent to your URL.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookfilterrule.html
    /// </summary>
    public class WebhookFilterRule
    {

        /// <summary>
        /// JsonPath
        /// A JsonPath expression that will be applied to the body/payload of the webhook. The value selected by
        /// the JsonPath expression must match the value specified in the MatchEquals field, otherwise the
        /// request will be ignored. For more information about JsonPath expressions, see Java JsonPath
        /// implementation in GitHub.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 150
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonPath")]
        public Union<string, IntrinsicFunction> JsonPath { get; set; }

        /// <summary>
        /// MatchEquals
        /// The value selected by the JsonPath expression must match what is supplied in the MatchEquals field,
        /// otherwise the request will be ignored. Properties from the target action configuration can be
        /// included as placeholders in this value by surrounding the action configuration key with curly
        /// braces. For example, if the value supplied here is &quot;refs/heads/{Branch}&quot; and the target action has
        /// an action configuration property called &quot;Branch&quot; with a value of &quot;master&quot;, the MatchEquals value
        /// will be evaluated as &quot;refs/heads/master&quot;. For a list of action configuration properties for built-in
        /// action types, see Pipeline Structure Reference Action Requirements.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 150
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchEquals")]
        public Union<string, IntrinsicFunction> MatchEquals { get; set; }

    }
}
