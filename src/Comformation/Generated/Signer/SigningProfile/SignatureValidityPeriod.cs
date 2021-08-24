using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Signer.SigningProfile
{
    /// <summary>
    /// AWS::Signer::SigningProfile SignatureValidityPeriod
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-signer-signingprofile-signaturevalidityperiod.html
    /// </summary>
    public class SignatureValidityPeriod
    {

        /// <summary>
        /// Value
        /// The numerical value of the time unit for signature validity.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<int, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Type
        /// The time unit for signature validity: DAYS | MONTHS | YEARS.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
