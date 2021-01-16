using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Domain
{
    /// <summary>
    /// AWS::Amplify::Domain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// SubDomainSettings
            /// The setting for the subdomain.
            /// Required: Yes
            /// Type: List of SubDomainSetting
            /// Update requires: No interruption
            /// </summary>
            public List<SubDomainSetting> SubDomainSettings { get; set; }

            /// <summary>
            /// AppId
            /// The unique ID for an Amplify app.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AppId { get; set; }

            /// <summary>
            /// AutoSubDomainIAMRole
            /// The required AWS Identity and Access Management (IAM) service role for the Amazon Resource Name
            /// (ARN) for automatically creating subdomains.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AutoSubDomainIAMRole { get; set; }

            /// <summary>
            /// DomainName
            /// The domain name for the domain association.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// EnableAutoSubDomain
            /// Enables the automated creation of subdomains for branches.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableAutoSubDomain { get; set; }

            /// <summary>
            /// AutoSubDomainCreationPatterns
            /// Sets the branch patterns for automatic subdomain creation.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AutoSubDomainCreationPatterns { get; set; }

        }

        public string Type { get; } = "AWS::Amplify::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }

    public static class DomainAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AutoSubDomainIAMRole = new ResourceAttribute<Union<string, IntrinsicFunction>>("AutoSubDomainIAMRole");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusReason = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusReason");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> EnableAutoSubDomain = new ResourceAttribute<Union<bool, IntrinsicFunction>>("EnableAutoSubDomain");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainStatus");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> AutoSubDomainCreationPatterns = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("AutoSubDomainCreationPatterns");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CertificateRecord = new ResourceAttribute<Union<string, IntrinsicFunction>>("CertificateRecord");
    }
}
