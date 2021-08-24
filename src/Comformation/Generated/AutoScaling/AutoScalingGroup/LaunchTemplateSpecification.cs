using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LaunchTemplateSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html
    /// </summary>
    public class LaunchTemplateSpecification
    {

        /// <summary>
        /// LaunchTemplateId
        /// The ID of the AWS::EC2::LaunchTemplate. You must specify either a LaunchTemplateName or a
        /// LaunchTemplateId.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public Union<string, IntrinsicFunction> LaunchTemplateId { get; set; }

        /// <summary>
        /// LaunchTemplateName
        /// The name of the AWS::EC2::LaunchTemplate. You must specify either a LaunchTemplateName or a
        /// LaunchTemplateId.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

        /// <summary>
        /// Version
        /// The version number. CloudFormation does not support specifying $Latest, or $Default for the template
        /// version number. However, you can specify LatestVersionNumber or DefaultVersionNumber using the
        /// Fn::GetAtt function.
        /// Note For an example of using the Fn::GetAtt function, see the Examples section of the
        /// AWS::AutoScaling::AutoScalingGroup documentation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
