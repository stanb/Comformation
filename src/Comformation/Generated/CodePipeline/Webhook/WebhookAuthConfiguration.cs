using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Webhook
{
    /// <summary>
    /// CodePipeline Webhook WebhookAuthConfiguration
    /// The WebhookAuthConfiguration property type configures the authentication applied to incoming webhook trigger
    /// requests. For more information, see Webhook Definition in the AWS CodePipeline API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookauthconfiguration.html
    /// </summary>
    public class WebhookAuthConfiguration
    {

        /// <summary>
        /// AllowedIPRange
        /// The property used to configure acceptance of webhooks within a specific IP range.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedIPRange")]
        public Union<string, IntrinsicFunction> AllowedIPRange { get; set; }

        /// <summary>
        /// SecretToken
        /// The property used to configure GitHub authentication.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretToken")]
        public Union<string, IntrinsicFunction> SecretToken { get; set; }

    }
}
