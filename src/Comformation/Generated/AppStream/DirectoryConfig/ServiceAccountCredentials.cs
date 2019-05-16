using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.DirectoryConfig
{
    /// <summary>
    /// AWS::AppStream::DirectoryConfig ServiceAccountCredentials
    /// The credentials for the service account used by the streaming instance to connect to the directory.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-serviceaccountcredentials.html
    /// </summary>
    public class ServiceAccountCredentials
    {

        /// <summary>
        /// AccountName
        /// The user name of the account. This account must have the following privileges: create computer
        /// objects, join computers to the domain, and change/reset the password on descendant computer objects
        /// for the organizational units specified.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountName")]
        public Union<string, IntrinsicFunction> AccountName { get; set; }

        /// <summary>
        /// AccountPassword
        /// The password for the account.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 127
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountPassword")]
        public Union<string, IntrinsicFunction> AccountPassword { get; set; }

    }
}
