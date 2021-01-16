using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority AccessDescription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-accessdescription.html
    /// </summary>
    public class AccessDescription
    {

        /// <summary>
        /// AccessMethod
        /// 		 		
        /// The type and format of AccessDescription information.
        /// 		 	
        /// Required: Yes
        /// Type: AccessMethod
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AccessMethod")]
        public AccessMethod AccessMethod { get; set; }

        /// <summary>
        /// AccessLocation
        /// 		
        /// The 			location of AccessDescription information.
        /// 	
        /// Required: Yes
        /// Type: GeneralName
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AccessLocation")]
        public GeneralName AccessLocation { get; set; }

    }
}
