using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority Subject
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-subject.html
    /// </summary>
    public class Subject
    {

        /// <summary>
        /// Country
        /// Two-digit code that specifies the country in which the certificate subject located.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Country")]
        public Union<string, IntrinsicFunction> Country { get; set; }

        /// <summary>
        /// Organization
        /// Legal name of the organization with which the certificate subject is affiliated.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Organization")]
        public Union<string, IntrinsicFunction> Organization { get; set; }

        /// <summary>
        /// OrganizationalUnit
        /// A subdivision or unit of the organization (such as sales or finance) with which the certificate
        /// subject is affiliated.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OrganizationalUnit")]
        public Union<string, IntrinsicFunction> OrganizationalUnit { get; set; }

        /// <summary>
        /// DistinguishedNameQualifier
        /// Disambiguating information for the certificate subject.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DistinguishedNameQualifier")]
        public Union<string, IntrinsicFunction> DistinguishedNameQualifier { get; set; }

        /// <summary>
        /// State
        /// State in which the subject of the certificate is located.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// CommonName
        /// Fully qualified domain name (FQDN) associated with the certificate subject.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CommonName")]
        public Union<string, IntrinsicFunction> CommonName { get; set; }

        /// <summary>
        /// SerialNumber
        /// The certificate serial number.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SerialNumber")]
        public Union<string, IntrinsicFunction> SerialNumber { get; set; }

        /// <summary>
        /// Locality
        /// The locality (such as a city or town) in which the certificate subject is located.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Locality")]
        public Union<string, IntrinsicFunction> Locality { get; set; }

        /// <summary>
        /// Title
        /// A personal title such as Mr.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Title")]
        public Union<string, IntrinsicFunction> Title { get; set; }

        /// <summary>
        /// Surname
        /// Family name.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Surname")]
        public Union<string, IntrinsicFunction> Surname { get; set; }

        /// <summary>
        /// GivenName
        /// First name.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GivenName")]
        public Union<string, IntrinsicFunction> GivenName { get; set; }

        /// <summary>
        /// Initials
        /// Concatenation that typically contains the first letter of the GivenName, the first letter of the
        /// middle name if one exists, and the first letter of the SurName.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Initials")]
        public Union<string, IntrinsicFunction> Initials { get; set; }

        /// <summary>
        /// Pseudonym
        /// Typically a shortened version of a longer GivenName. For example, Jonathan is often shortened to
        /// John. Elizabeth is often shortened to Beth, Liz, or Eliza.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Pseudonym")]
        public Union<string, IntrinsicFunction> Pseudonym { get; set; }

        /// <summary>
        /// GenerationQualifier
        /// Typically a qualifier appended to the name of an individual. Examples include Jr. for junior, Sr.
        /// for senior, and III for third.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("GenerationQualifier")]
        public Union<string, IntrinsicFunction> GenerationQualifier { get; set; }

    }
}
