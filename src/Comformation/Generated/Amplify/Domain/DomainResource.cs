using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Domain
{
    /// <summary>
    /// AWS::Amplify::Domain
    /// The AWS::Amplify::Domain resource allows you to connect a custom domain to your app.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// SubDomainSettings
            /// Setting structure for the Subdomain.
            /// Required: Yes
            /// Type: List of SubDomainSetting
            /// Update requires: No interruption
            /// </summary>
			public List<SubDomainSetting> SubDomainSettings { get; set; }

            /// <summary>
            /// AppId
            /// Unique Id for an Amplify App.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AppId { get; set; }

            /// <summary>
            /// DomainName
            /// Domain name for the Domain Association.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

        }

        public string Type { get; } = "AWS::Amplify::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }

	public static class DomainAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusReason = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusReason");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainStatus");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CertificateRecord = new ResourceAttribute<Union<string, IntrinsicFunction>>("CertificateRecord");
	}
}
