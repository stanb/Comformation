using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// AWS::AmazonMQ::Broker LdapServerMetadata
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-ldapservermetadata.html
    /// </summary>
    public class LdapServerMetadata
    {

        /// <summary>
        /// Hosts
        /// Specifies the location of the LDAP server such as AWS Directory Service for Microsoft Active
        /// Directory. Optional failover server.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Hosts")]
        public List<Union<string, IntrinsicFunction>> Hosts { get; set; }

        /// <summary>
        /// UserRoleName
        /// Specifies the name of the LDAP attribute for the user group membership.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserRoleName")]
        public Union<string, IntrinsicFunction> UserRoleName { get; set; }

        /// <summary>
        /// UserSearchMatching
        /// The LDAP search filter used to find users within the userBase. The client&#39;s username is substituted
        /// into the {0} placeholder in the search filter. For example, if this option is set to (uid={0}) and
        /// the received username is janedoe, the search filter becomes (uid=janedoe) after string substitution.
        /// It will result in matching an entry like uid=janedoe, ou=Users, ou=corp, dc=corp, dc=example,
        /// dc=com.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserSearchMatching")]
        public Union<string, IntrinsicFunction> UserSearchMatching { get; set; }

        /// <summary>
        /// RoleName
        /// Specifies the LDAP attribute that identifies the group name attribute in the object returned from
        /// the group membership query.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleName")]
        public Union<string, IntrinsicFunction> RoleName { get; set; }

        /// <summary>
        /// UserBase
        /// Select a particular subtree of the directory information tree (DIT) to search for user entries. The
        /// subtree is specified by a DN, which specifies the base node of the subtree. For example, by setting
        /// this option to ou=Users,ou=corp, dc=corp, dc=example, dc=com, the search for user entries is
        /// restricted to the subtree beneath ou=Users,ou=corp, dc=corp, dc=example, dc=com.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserBase")]
        public Union<string, IntrinsicFunction> UserBase { get; set; }

        /// <summary>
        /// UserSearchSubtree
        /// The directory search scope for the user. If set to true, scope is to search the entire subtree.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserSearchSubtree")]
        public Union<bool, IntrinsicFunction> UserSearchSubtree { get; set; }

        /// <summary>
        /// RoleSearchMatching
        /// The LDAP search filter used to find roles within the roleBase. The distinguished name of the user
        /// matched by userSearchMatching is substituted into the {0} placeholder in the search filter. The
        /// client&#39;s username is substituted into the {1} placeholder. For example, if you set this option to
        /// (member=uid={1}) for the user janedoe, the search filter becomes (member=uid=janedoe) after string
        /// substitution. It matches all role entries that have a member attribute equal to uid=janedoe under
        /// the subtree selected by the RoleBases.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleSearchMatching")]
        public Union<string, IntrinsicFunction> RoleSearchMatching { get; set; }

        /// <summary>
        /// ServiceAccountUsername
        /// Service account username. A service account is an account in your LDAP server that has access to
        /// initiate a connection. For example, cn=admin,dc=corp, dc=example, dc=com.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccountUsername")]
        public Union<string, IntrinsicFunction> ServiceAccountUsername { get; set; }

        /// <summary>
        /// RoleBase
        /// The distinguished name of the node in the directory information tree (DIT) to search for roles or
        /// groups. For example, ou=group, ou=corp, dc=corp, dc=example, dc=com.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleBase")]
        public Union<string, IntrinsicFunction> RoleBase { get; set; }

        /// <summary>
        /// ServiceAccountPassword
        /// Service account password. A service account is an account in your LDAP server that has access to
        /// initiate a connection. For example, cn=admin,dc=corp, dc=example, dc=com.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccountPassword")]
        public Union<string, IntrinsicFunction> ServiceAccountPassword { get; set; }

        /// <summary>
        /// RoleSearchSubtree
        /// The directory search scope for the role. If set to true, scope is to search the entire subtree.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleSearchSubtree")]
        public Union<bool, IntrinsicFunction> RoleSearchSubtree { get; set; }

    }
}
