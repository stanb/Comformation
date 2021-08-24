using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate Qualifier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-qualifier.html
    /// </summary>
    public class Qualifier
    {

        /// <summary>
        /// CpsUri
        /// 		
        /// Contains a pointer to a certification practice statement (CPS) published by the 			CA.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CpsUri")]
        public Union<string, IntrinsicFunction> CpsUri { get; set; }

    }
}
