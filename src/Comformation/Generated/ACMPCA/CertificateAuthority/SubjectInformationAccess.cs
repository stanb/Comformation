using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority SubjectInformationAccess
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subjectinformationaccess.html
    /// </summary>
    public class SubjectInformationAccess
    {

        /// <summary>
        /// SubjectInformationAccess_
        /// </summary>
        [JsonProperty("SubjectInformationAccess")]
        public List<AccessDescription> SubjectInformationAccess_ { get; set; }

    }
}
