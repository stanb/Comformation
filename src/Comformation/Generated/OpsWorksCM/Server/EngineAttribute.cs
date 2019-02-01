using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorksCM.Server
{
    /// <summary>
    /// AWS OpsWorks CM Server EngineAttribute
    /// The EngineAttribute property type specifies administrator credentials for an AWS OpsWorks for Chef Automate or
    /// OpsWorks for Puppet Enterprise server.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworkscm-server-engineattribute.html
    /// </summary>
    public class EngineAttribute
    {

        /// <summary>
        /// Value
        /// The value of the engine attribute.
        /// Attribute value for Chef Automate servers: CHEF_PIVOTAL_KEY: A base64-encoded RSA public key. The
        /// corresponding private key is required to access the Chef API. You can generate this key by running
        /// the following OpenSSL command on Linux-based computers. openssl genrsa -out pivotal_key_file_name.
        /// pem 2048 On Windows-based computers, you can use the PuTTYgen utility to generate a base64-encoded
        /// RSA private key. For more information, see PuTTYgen - Key Generator for PuTTY on Windows on SSH.
        /// com.
        /// Attribute value for Puppet Enterprise servers: PUPPET_ADMIN_PASSWORD: An administrator password that
        /// you can use to sign in to the Puppet Enterprise console webpage after the server is online. The
        /// password must use between 8 and 32 ASCII characters.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Name
        /// The name of the engine attribute.
        /// Attribute name for Chef Automate servers: CHEF_PIVOTAL_KEY
        /// Attribute name for Puppet Enterprise servers: PUPPET_ADMIN_PASSWORD
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
