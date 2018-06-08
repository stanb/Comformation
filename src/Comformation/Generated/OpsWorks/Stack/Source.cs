using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS OpsWorks Source Type
    /// Describes the information required to retrieve a cookbook or app from a repository for the
    /// AWS::OpsWorks::Stack or AWS::OpsWorks::App resource types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// Password
        /// This parameter depends on the repository type. For Amazon S3 bundles, set Password to the
        /// appropriate IAM secret access key. For HTTP bundles, Git repositories, and Subversion repositories,
        /// set Password to the appropriate password.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// Revision
        /// The application's version. With AWS OpsWorks, you can deploy new versions of an application. One of
        /// the simplest approaches is to have branches or revisions in your repository that represent different
        /// versions that can potentially be deployed.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Revision")]
        public Union<string, IntrinsicFunction> Revision { get; set; }

        /// <summary>
        /// SshKey
        /// The repository's SSH key. For more information, see Using Git Repository SSH Keys in the AWS
        /// OpsWorks User Guide.
        /// To pass in an SSH key as a parameter, see the following example:
        /// "Parameters" : { "GitSSHKey" : { "Description" : "Change SSH key newlines to commas. ", "Type" :
        /// "CommaDelimitedList", "NoEcho" : "true" }, . . . "CustomCookbooksSource": { "Revision" : { "Ref":
        /// "GitRevision"}, "SshKey" : { "Fn::Join" : [ "\n", { "Ref": "GitSSHKey"} ] }, "Type": "git", "Url": {
        /// "Ref": "GitURL"} } . . .
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SshKey")]
        public Union<string, IntrinsicFunction> SshKey { get; set; }

        /// <summary>
        /// Type
        /// The repository type.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Url
        /// The source URL.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

        /// <summary>
        /// Username
        /// This parameter depends on the repository type. For Amazon S3 bundles, set Username to the
        /// appropriate IAM access key ID. For HTTP bundles, Git repositories, and Subversion repositories, set
        /// Username to the appropriate user name.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

    }
}
