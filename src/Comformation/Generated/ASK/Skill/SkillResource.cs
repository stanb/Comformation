using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ASK.Skill
{
    /// <summary>
    /// Alexa::ASK::Skill
    /// The Alexa::ASK::Skill resource creates an Alexa skill that enables customers to access new abilities. For more
    /// information on developing a skill, see the Build Skills with the Alexa Skills Kit developer documentation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html
    /// </summary>
    public class SkillResource : ResourceBase
    {
        public class SkillProperties
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// Login with Amazon (LWA) configuration used to authenticate with the Alexa service. Only Login with
            /// Amazon clients created through the Amazon Developer Console are supported. The Client ID, Client
            /// Secret, and Refresh Token are required.
            /// Required: Yes
            /// Type: AuthenticationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public AuthenticationConfiguration AuthenticationConfiguration { get; set; }

            /// <summary>
            /// VendorId
            /// The vendor ID associated with the Amazon developer account that will host the skill. Details for
            /// retrieving the vendor ID are in How to get your vendor ID. The provided LWA credentials must be
            /// linked to the developer account associated with this vendor ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VendorId { get; set; }

            /// <summary>
            /// SkillPackage
            /// Configuration for the skill package that contains the components of the Alexa Skill. Skill packages
            /// are retrieved from an Amazon S3 bucket and key and used to create and update the skill. More details
            /// about the skill package format are located in the Skill Package API Reference.
            /// Required: Yes
            /// Type: SkillPackage
            /// Update requires: No interruption
            /// </summary>
			public SkillPackage SkillPackage { get; set; }

        }

        public string Type { get; } = "Alexa::ASK::Skill";

        public SkillProperties Properties { get; } = new SkillProperties();

    }
}
