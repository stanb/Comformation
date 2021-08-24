using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate EdiPartyName
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-edipartyname.html
    /// </summary>
    public class EdiPartyName
    {

        /// <summary>
        /// PartyName
        /// 		
        /// Specifies the party name.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PartyName")]
        public Union<string, IntrinsicFunction> PartyName { get; set; }

        /// <summary>
        /// NameAssigner
        /// 		
        /// Specifies the name assigner.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("NameAssigner")]
        public Union<string, IntrinsicFunction> NameAssigner { get; set; }

    }
}
