using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Webhook
{
    /// <summary>
    /// AWS::CodePipeline::Webhook WebhookAuthConfiguration
    /// The authentication applied to incoming webhook trigger requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookauthconfiguration.html
    /// </summary>
    public class WebhookAuthConfiguration
    {

        /// <summary>
        /// AllowedIPRange
        /// The property used to configure acceptance of webhooks in an IP address range. For IP, only the
        /// AllowedIPRange property must be set. This property must be set to a valid CIDR range.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedIPRange")]
        public Union<string, IntrinsicFunction> AllowedIPRange { get; set; }

        /// <summary>
        /// SecretToken
        /// The property used to configure GitHub authentication. For GITHUB_HMAC, only the SecretToken property
        /// must be set.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretToken")]
        public Union<string, IntrinsicFunction> SecretToken { get; set; }

    }
}
