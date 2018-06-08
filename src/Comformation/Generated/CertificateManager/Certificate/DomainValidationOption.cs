using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Certificate
{
    /// <summary>
    /// AWS Certificate Manager Certificate DomainValidationOption
    /// DomainValidationOption is a property of the AWS::CertificateManager::Certificate resource that specifies the
    /// AWS Certificate Manager (ACM) Certificate domain that registrars use to send validation emails.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html
    /// </summary>
    public class DomainValidationOption
    {

        /// <summary>
        /// DomainName
        /// Fully Qualified Domain Name (FQDN) of the Certificate that you are requesting.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// ValidationDomain
        /// The domain that domain name registrars use to send validation emails. Registrars use this value as
        /// the email address suffix when sending emails to verify your identity. This value must be the same as
        /// the domain name or a superdomain of the domain name. For more information, see the ValidationDomain
        /// content for the DomainValidationOption data type in the AWS Certificate Manager API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ValidationDomain")]
        public Union<string, IntrinsicFunction> ValidationDomain { get; set; }

    }
}
