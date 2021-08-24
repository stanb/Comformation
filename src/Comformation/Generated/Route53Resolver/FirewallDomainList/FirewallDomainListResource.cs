using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53Resolver.FirewallDomainList
{
    /// <summary>
    /// AWS::Route53Resolver::FirewallDomainList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewalldomainlist.html
    /// </summary>
    public class FirewallDomainListResource : ResourceBase
    {
        public class FirewallDomainListProperties
        {
            /// <summary>
            /// Name
            /// The name of the domain list.
            /// Required: No
            /// Type: String
            /// Maximum: 64
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9\-_&#39; &#39;]+)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Domains
            /// A list of the domain lists that you have defined.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Domains { get; set; }

            /// <summary>
            /// DomainFileUrl
            /// The fully qualified URL or URI of the file stored in Amazon Simple Storage Service 			(Amazon S3)
            /// that contains the list of domains to import.
            /// The file must be in an S3 bucket that&#39;s in the same Region as your DNS Firewall. The file must be a
            /// text file and must contain a single domain per line.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DomainFileUrl { get; set; }

            /// <summary>
            /// Tags
            /// A list of the tag keys and values that you want to associate with the domain list.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Route53Resolver::FirewallDomainList";

        public FirewallDomainListProperties Properties { get; } = new FirewallDomainListProperties();

    }

    public static class FirewallDomainListAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> DomainCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("DomainCount");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StatusMessage = new ResourceAttribute<Union<string, IntrinsicFunction>>("StatusMessage");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ManagedOwnerName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ManagedOwnerName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatorRequestId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatorRequestId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ModificationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("ModificationTime");
    }
}
