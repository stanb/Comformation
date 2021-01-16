using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ASK.Skill
{
    /// <summary>
    /// Alexa::ASK::Skill SkillPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-skillpackage.html
    /// </summary>
    public class SkillPackage
    {

        /// <summary>
        /// S3BucketRole
        /// ARN of the IAM role that grants the Alexa service (alexa-appkit. amazon. com) permission to access
        /// the bucket and retrieve the skill package. This property is optional. If you do not provide it, the
        /// bucket must be publicly accessible or configured with a policy that allows this access. Otherwise,
        /// AWS CloudFormation cannot create the skill.
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
