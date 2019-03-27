using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Webhook
{
    /// <summary>
    /// CodePipeline Webhook WebhookFilterRule
    /// The WebhookFilterRule property type specifies events that will trigger a webhook. For more information, see
    /// Webhook Definition in the AWS CodePipeline API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookfilterrule.html
    /// </summary>
    public class WebhookFilterRule
    {

        /// <summary>
        /// JsonPath
        /// A JsonPath expression that will be applied to the body/payload of the webhook.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonPath")]
        public Union<string, IntrinsicFunction> JsonPath { get; set; }

        /// <summary>
        /// MatchEquals
        /// The value selected by the JsonPath expression must match what is supplied in the MatchEquals field,
        /// otherwise the request will be ignored.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchEquals")]
        public Union<string, IntrinsicFunction> MatchEquals { get; set; }

    }
}
