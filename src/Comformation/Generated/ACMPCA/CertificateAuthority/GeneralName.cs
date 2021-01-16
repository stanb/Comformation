using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority GeneralName
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-generalname.html
    /// </summary>
    public class GeneralName
    {

        /// <summary>
        /// OtherName
        /// 		
        /// Represents 				GeneralName using an OtherName 			object.
        /// 	
        /// Required: No
        /// Type: OtherName
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OtherName")]
        public OtherName OtherName { get; set; }

        /// <summary>
        /// Rfc822Name
        /// 		
        /// Represents 				GeneralName as an RFC 				822 email address.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Rfc822Name")]
        public Union<string, IntrinsicFunction> Rfc822Name { get; set; }

        /// <summary>
        /// DnsName
        /// 		
        /// Represents 				GeneralName as a DNS name.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 253
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DnsName")]
        public Union<string, IntrinsicFunction> DnsName { get; set; }

        /// <summary>
        /// DirectoryName
        /// Contains information about the certificate subject. The certificate can be one issued by your
        /// private certificate authority (CA) or it can be your private CA certificate. The Subject field in
        /// the certificate identifies the entity that owns or controls the public key in the certificate. The
        /// entity can be a user, computer, device, or service. The Subject must contain an X. 500 distinguished
        /// name (DN). A DN is a sequence of relative distinguished names (RDNs). The RDNs are separated by
        /// commas in the certificate. The DN must be unique for each entity, but your private CA can issue more
        /// than one certificate with the same DN to the same entity.
        /// Required: No
        /// Type: Subject
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DirectoryName")]
        public Subject DirectoryName { get; set; }

        /// <summary>
        /// EdiPartyName
        /// 		
        /// Represents 				GeneralName as an EdiPartyName 			object.
        /// 	
        /// Required: No
        /// Type: EdiPartyName
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EdiPartyName")]
        public EdiPartyName EdiPartyName { get; set; }

        /// <summary>
        /// UniformResourceIdentifier
        /// 		
        /// Represents 				GeneralName as a URI.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 253
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("UniformResourceIdentifier")]
        public Union<string, IntrinsicFunction> UniformResourceIdentifier { get; set; }

        /// <summary>
        /// IpAddress
        /// 		
        /// Represents 				GeneralName as an IPv4 or IPv6 address.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 39
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IpAddress")]
        public Union<string, IntrinsicFunction> IpAddress { get; set; }

        /// <summary>
        /// RegisteredId
        /// 		
        /// 			Represents GeneralName as an object identifier 			(OID).
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 64
        /// Pattern: ^([0-2])\. ([0-9]|([0-3][0-9]))((\. ([0-9]+)){0,126})$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RegisteredId")]
        public Union<string, IntrinsicFunction> RegisteredId { get; set; }

    }
}
