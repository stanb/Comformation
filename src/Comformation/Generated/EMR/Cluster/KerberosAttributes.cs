using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster KerberosAttributes
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-kerberosattributes.html
    /// </summary>
    public class KerberosAttributes
    {

        /// <summary>
        /// ADDomainJoinPassword
        /// The Active Directory password for ADDomainJoinUser.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ADDomainJoinPassword")]
        public Union<string, IntrinsicFunction> ADDomainJoinPassword { get; set; }

        /// <summary>
        /// ADDomainJoinUser
        /// Required only when establishing a cross-realm trust with an Active Directory domain. A user with
        /// sufficient privileges to join resources to the domain.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ADDomainJoinUser")]
        public Union<string, IntrinsicFunction> ADDomainJoinUser { get; set; }

        /// <summary>
        /// CrossRealmTrustPrincipalPassword
        /// Required only when establishing a cross-realm trust with a KDC in a different realm. The cross-realm
        /// principal password, which must be identical across realms.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrossRealmTrustPrincipalPassword")]
        public Union<string, IntrinsicFunction> CrossRealmTrustPrincipalPassword { get; set; }

        /// <summary>
        /// KdcAdminPassword
        /// The password used within the cluster for the kadmin service on the cluster-dedicated KDC, which
        /// maintains Kerberos principals, password policies, and keytabs for the cluster.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KdcAdminPassword")]
        public Union<string, IntrinsicFunction> KdcAdminPassword { get; set; }

        /// <summary>
        /// Realm
        /// The name of the Kerberos realm to which all nodes in a cluster belong. For example, EC2. INTERNAL.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Realm")]
        public Union<string, IntrinsicFunction> Realm { get; set; }

    }
}
