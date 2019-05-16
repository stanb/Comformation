using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project ProjectTriggers
    /// ProjectTriggers is a property of the AWS CodeBuild Project resource that specifies webhooks that trigger an
    /// AWS CodeBuild build.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html
    /// </summary>
    public class ProjectTriggers
    {

        /// <summary>
        /// FilterGroups
        /// A list of lists of WebhookFilter objects used to determine which webhook events are triggered. At
        /// least one WebhookFilter in the array must specify EVENT as its type.
        /// Required: No
        /// Type: List of FilterGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterGroups")]
        public List<WebhookFilter> FilterGroups { get; set; }

        /// <summary>
        /// Webhook
        /// Specifies whether or not to begin automatically rebuilding the source code every time a code change
        /// is pushed to the repository.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Webhook")]
        public Union<bool, IntrinsicFunction> Webhook { get; set; }

    }
}
