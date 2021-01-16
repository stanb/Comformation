using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Certificate
{
    /// <summary>
    /// AWS::CertificateManager::Certificate DomainValidationOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-certificate-domainvalidationoption.html
    /// </summary>
    public class DomainValidationOption
    {

        /// <summary>
        /// DomainName
        /// A fully qualified domain name (FQDN) in the certificate request.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 253
        /// Pattern: ^(\*\. )?(((?!-)[A-Za-z0-9-]{0,62}[A-Za-z0-9])\. )+((?!-)[A-Za-z0-9-]{1,62}[A-Za-z0-9])$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// HostedZoneId
        /// The HostedZoneId option, which is available if you are using Route 53 as your domain registrar,
        /// causes ACM to add your CNAME to the domain record. Your list of DomainValidationOptions must contain
        /// one and only one of the domain-validation options, and the HostedZoneId can be used only when DNS is
        /// specified as your validation method.
        /// Use the Route 53 ListHostedZones API to discover IDs for available hosted zones.
        /// Note The ListHostedZones API returns IDs in the format &quot;/hostedzone/Z111111QQQQQQQ&quot;, but
        /// CloudFormation requires the IDs to be in the format &quot;Z111111QQQQQQQ&quot;.
        /// When you change your DomainValidationOptions, a new resource is created.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostedZoneId")]
        public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

        /// <summary>
        /// ValidationDomain
        /// The domain name to which you want ACM to send validation emails. This domain name is the suffix of
        /// the email addresses that you want ACM to use. This must be the same as the DomainName value or a
        /// superdomain of the DomainName value. For example, if you request a certificate for testing. example.
        /// com, you can specify example. com as this value. In that case, ACM sends domain validation emails to
        /// the following five addresses:
        /// admin@example. com administrator@example. com hostmaster@example. com postmaster@example. com
        /// webmaster@example. com
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 253
        /// Pattern: ^(\*\. )?(((?!-)[A-Za-z0-9-]{0,62}[A-Za-z0-9])\. )+((?!-)[A-Za-z0-9-]{1,62}[A-Za-z0-9])$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ValidationDomain")]
        public Union<string, IntrinsicFunction> ValidationDomain { get; set; }

    }
}
