using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment LaunchTemplateSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html
    /// </summary>
    public class LaunchTemplateSpecification
    {

        /// <summary>
        /// LaunchTemplateName
        /// The name of the launch template.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// Version
        /// The version number of the launch template, $Latest, or $Default.
        /// If the value is $Latest, the latest version of the launch template is used. If the value is
        /// $Default, the default version of the launch template is used.
        /// Important After the compute environment is created, the launch template version that&#39;s used isn&#39;t
        /// changed, even if the $Default or $Latest version for the launch template is updated. To use a new
        /// launch template version, create a new compute environment, add the new compute environment to the
        /// existing job queue, remove the old compute environment from the job queue, and delete the old
        /// compute environment.
        /// Default: $Default.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the launch template.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

    }
}
