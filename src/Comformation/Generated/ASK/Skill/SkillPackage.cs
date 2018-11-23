using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ASK.Skill
{
    /// <summary>
    /// Alexa::ASK::Skill SkillPackage
    /// The SkillPackage property type contains configuration details for the skill package that contains the
    /// components of the Alexa Skill. Skill packages are retrieved from an Amazon S3 bucket and key and used to
    /// create and update the skill. More details about the skill package format are located in the Skill Package API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html
    /// </summary>
    public class SkillPackage
    {

        /// <summary>
        /// S3BucketRole
        /// ARN of the role that grants the Alexa service permission to access the bucket and retrieve the skill
        /// package. This role is optional, and if not provided the bucket must be configured with a policy
        /// allowing this access, or be publicly accessible, in order for AWS CloudFormation to create the
        /// skill.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketRole")]
        public Union<string, IntrinsicFunction> S3BucketRole { get; set; }

        /// <summary>
        /// S3ObjectVersion
        /// If you have S3 versioning enabled, the version ID of the skill package. zip file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ObjectVersion")]
        public Union<string, IntrinsicFunction> S3ObjectVersion { get; set; }

        /// <summary>
        /// S3Bucket
        /// The name of the Amazon S3 bucket where the . zip file that contains the skill package is stored.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The location and name of the skill package . zip file.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

        /// <summary>
        /// Overrides
        /// Overrides to the skill package to apply when creating or updating the skill. Values provided here do
        /// not modify the contents of the original skill package. Currently, only overriding values inside of
        /// the skill manifest component of the package is supported.
        /// Required: No
        /// Type: Overrides
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overrides")]
        public Overrides Overrides { get; set; }

    }
}
