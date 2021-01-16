using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.CodeSigningConfig
{
    /// <summary>
    /// AWS::Lambda::CodeSigningConfig AllowedPublishers
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-codesigningconfig-allowedpublishers.html
    /// </summary>
    public class AllowedPublishers
    {

        /// <summary>
        /// SigningProfileVersionArns
        /// The Amazon Resource Name (ARN) for each of the signing profiles. A signing profile defines a trusted
        /// user who can sign a code package.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigningProfileVersionArns")]
        public List<Union<string, IntrinsicFunction>> SigningProfileVersionArns { get; set; }

    }
}
