using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project BuildStatusConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-buildstatusconfig.html
    /// </summary>
    public class BuildStatusConfig
    {

        /// <summary>
        /// Context
        /// Specifies the context of the build status CodeBuild sends to the source provider. The usage of this
        /// parameter depends on the source provider.
        /// Bitbucket This parameter is used for the name parameter in the Bitbucket commit status. For more
        /// information, see build in the Bitbucket API documentation. GitHub/GitHub Enterprise Server This
        /// parameter is used for the context parameter in the GitHub commit status. For more information, see
        /// Create a commit status in the GitHub developer guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Context")]
        public Union<string, IntrinsicFunction> Context { get; set; }

        /// <summary>
        /// TargetUrl
        /// Specifies the target url of the build status CodeBuild sends to the source provider. The usage of
        /// this parameter depends on the source provider.
        /// Bitbucket This parameter is used for the url parameter in the Bitbucket commit status. For more
        /// information, see build in the Bitbucket API documentation. GitHub/GitHub Enterprise Server This
        /// parameter is used for the target_url parameter in the GitHub commit status. For more information,
        /// see Create a commit status in the GitHub developer guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetUrl")]
        public Union<string, IntrinsicFunction> TargetUrl { get; set; }

    }
}
