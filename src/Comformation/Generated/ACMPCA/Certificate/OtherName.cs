using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate OtherName
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-othername.html
    /// </summary>
    public class OtherName
    {

        /// <summary>
        /// TypeId
        /// 		
        /// Specifies an OID.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 64
        /// Pattern: ^([0-2])\. ([0-9]|([0-3][0-9]))((\. ([0-9]+)){0,126})$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TypeId")]
        public Union<string, IntrinsicFunction> TypeId { get; set; }

        /// <summary>
        /// Value
        /// 		
        /// Specifies an OID value.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
