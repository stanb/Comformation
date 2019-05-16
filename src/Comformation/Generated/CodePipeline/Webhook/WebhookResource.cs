using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Webhook
{
    /// <summary>
    /// AWS::CodePipeline::Webhook
    /// The AWS::CodePipeline::Webhook resource creates and registers your webhook. After the webhook is created and
    /// registered, it triggers your pipeline to start every time an external event occurs. For more information, see
    /// Configure Your GitHub Pipelines to Use Webhooks for Change Detection in the AWS CodePipeline User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html
    /// </summary>
    public class WebhookResource : ResourceBase
    {
        public class WebhookProperties
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// Properties that configure the authentication applied to incoming webhook trigger requests. The
            /// required properties depend on the authentication type. For GITHUB_HMAC, only the SecretToken
            /// property must be set. For IP, only the AllowedIPRange property must be set to a valid CIDR range.
            /// For UNAUTHENTICATED, no properties can be set.
            /// Required: Yes
            /// Type: WebhookAuthConfiguration
            /// Update requires: No interruption
            /// </summary>
			public WebhookAuthConfiguration AuthenticationConfiguration { get; set; }

            /// <summary>
            /// Filters
            /// A list of rules applied to the body/payload sent in the POST request to a webhook URL. All defined
            /// rules must pass for the request to be accepted and the pipeline started.
            /// Required: Yes
            /// Type: List of WebhookFilterRule
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<WebhookFilterRule> Filters { get; set; }

            /// <summary>
            /// Authentication
            /// Supported options are GITHUB_HMAC, IP and UNAUTHENTICATED.
            /// For information about the authentication scheme implemented by GITHUB_HMAC, see Securing your
            /// webhooks on the GitHub Developer website. IP will reject webhooks trigger requests unless they
            /// originate from an IP within the IP range whitelisted in the authentication configuration.
            /// UNAUTHENTICATED will accept all webhook trigger requests regardless of origin.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: GITHUB_HMAC | IP | UNAUTHENTICATED
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Authentication { get; set; }

            /// <summary>
            /// TargetPipeline
            /// The name of the pipeline you want to connect to the webhook.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: [A-Za-z0-9. @\-_]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetPipeline { get; set; }

            /// <summary>
            /// TargetAction
            /// The name of the action in a pipeline you want to connect to the webhook. The action must be from the
            /// source (first) stage of the pipeline.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: [A-Za-z0-9. @\-_]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetAction { get; set; }

            /// <summary>
            /// Name
            /// The name of the webhook.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: [A-Za-z0-9. @\-_]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// TargetPipelineVersion
            /// The version number of the pipeline to be connected to the trigger request.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> TargetPipelineVersion { get; set; }

            /// <summary>
            /// RegisterWithThirdParty
            /// Configures a connection between the webhook that was created and the external tool with events to be
            /// detected.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> RegisterWithThirdParty { get; set; }

        }

        public string Type { get; } = "AWS::CodePipeline::Webhook";

        public WebhookProperties Properties { get; } = new WebhookProperties();

    }

	public static class WebhookAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Url = new ResourceAttribute<Union<string, IntrinsicFunction>>("Url");
	}
}
