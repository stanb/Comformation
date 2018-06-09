using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project ProjectTriggers
    /// ProjectTriggers is a property of the AWS::CodeBuild::Project resource that specifies the environment for an
    /// AWS CodeBuild project.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html
    /// </summary>
    public class ProjectTriggers
    {

        /// <summary>
        /// Webhook
        /// Specifies whether or not to begin automatically rebuilding the source code every time a code change
        /// is pushed to the repository.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Webhook")]
        public Union<bool, IntrinsicFunction> Webhook { get; set; }

    }
}
