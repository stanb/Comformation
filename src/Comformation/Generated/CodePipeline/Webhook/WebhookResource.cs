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
            /// Properties that configure the authentication applied to incoming webhook trigger requests. For more
            /// information, see Webhook Definition in the AWS CodePipeline API Reference.
            /// Required: Yes
            /// Type: AWS CodePipeline Webhook WebhookAuthConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<WebhookAuthConfiguration, IntrinsicFunction> AuthenticationConfiguration { get; set; }

            /// <summary>
            /// Filters
            /// A list of rules applied to the body/payload sent in the POST request to a webhook URL. All defined
            /// rules must pass for the request to be accepted and the pipeline started.
            /// Required: Yes
            /// Type: List of AWS CodePipeline Webhook WebhookFilterRule property types
            /// Update requires: No interruption
            /// </summary>
			public Union<List<WebhookFilterRule>, IntrinsicFunction> Filters { get; set; }

            /// <summary>
            /// Authentication
            /// The type of authentication scheme that allows the trigger request to be accepted. For more
            /// information, see Webhook Definition in the AWS CodePipeline API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Authentication { get; set; }

            /// <summary>
            /// TargetPipeline
            /// The name of the pipeline you want to connect to the webhook.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetPipeline { get; set; }

            /// <summary>
            /// TargetAction
            /// The name of the action in a pipeline you want to connect to the webhook. The action must be from the
            /// source (first) stage of the pipeline.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetAction { get; set; }

            /// <summary>
            /// Name
            /// The name of the webhook to be created and, if applicable, to register with a supported third party.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// TargetPipelineVersion
            /// The version number of the pipeline to be connected to the trigger request.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> TargetPipelineVersion { get; set; }

            /// <summary>
            /// RegisterWithThirdParty
            /// Indicates whether to register the webhook with a third party. Third party registration configures a
            /// connection between the webhook that was created and the external tool, such as GitHub, with events
            /// to be detected.
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
        public static readonly ResourceAttribute<string> Url = new ResourceAttribute<string>("Url");
	}
}
