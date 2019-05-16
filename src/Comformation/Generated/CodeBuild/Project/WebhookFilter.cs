using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project WebhookFilter
    /// WebhookFilter is a structure of the FilterGroups property on the AWS CodeBuild Project ProjectTriggers
    /// property type that specifies which webhooks trigger an AWS CodeBuild build.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-webhookfilter.html
    /// </summary>
    public class WebhookFilter
    {

        /// <summary>
        /// Pattern
        /// For a WebHookFilter that uses EVENT type, a comma-separated string that specifies one or more
        /// events. For example, the webhook filter PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED allows all
        /// push, pull request created, and pull request updated events to trigger a build.
        /// For a WebHookFilter that uses any of the other filter types, a regular expression pattern. For
        /// example, a WebHookFilter that uses HEAD_REF for its type and the pattern ^refs/heads/ triggers a
        /// build when the head reference is a branch with a reference name refs/heads/branch-name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pattern")]
        public Union<string, IntrinsicFunction> Pattern { get; set; }

        /// <summary>
        /// Type
        /// The type of webhook filter. There are five webhook filter types: EVENT, ACTOR_ACCOUNT_ID, HEAD_REF,
        /// BASE_REF, and FILE_PATH.
        /// EVENT A webhook event triggers a build when the provided pattern matches one of four event types:
        /// PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED, and PULL_REQUEST_REOPENED. The EVENT patterns are
        /// specified as a comma-separated string. For example, PUSH, PULL_REQUEST_CREATED, PULL_REQUEST_UPDATED
        /// filters all push, pull request created, and pull request updated events. Note The
        /// PULL_REQUEST_REOPENED works with GitHub and GitHub Enterprise only. ACTOR_ACCOUNT_ID A webhook event
        /// triggers a build when a GitHub, GitHub Enterprise, or Bitbucket account ID matches the regular
        /// expression pattern. HEAD_REF A webhook event triggers a build when the head reference matches the
        /// regular expression pattern. For example, refs/heads/branch-name and refs/tags/tag-name. Works with
        /// GitHub and GitHub Enterprise push, GitHub and GitHub Enterprise pull request, Bitbucket push, and
        /// Bitbucket pull request events. BASE_REF A webhook event triggers a build when the base reference
        /// matches the regular expression pattern. For example, refs/heads/branch-name. Note Works with pull
        /// request events only. FILE_PATH A webhook triggers a build when the path of a changed file matches
        /// the regular expression pattern. Note Works with GitHub and GitHub Enterprise push events only.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ACTOR_ACCOUNT_ID | BASE_REF | EVENT | FILE_PATH | HEAD_REF
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ExcludeMatchedPattern
        /// Used to indicate that the pattern determines which webhook events do not trigger a build. If true,
        /// then a webhook event that does not match the pattern triggers a build. If false, then a webhook
        /// event that matches the pattern triggers a build.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeMatchedPattern")]
        public Union<bool, IntrinsicFunction> ExcludeMatchedPattern { get; set; }

    }
}
