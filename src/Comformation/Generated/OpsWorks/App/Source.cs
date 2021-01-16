using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS::OpsWorks::Stack Source
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// Password
        /// When included in a request, the parameter depends on the repository type.
        /// For Amazon S3 bundles, set Password to the appropriate IAM secret access key. For HTTP bundles and
        /// Subversion repositories, set Password to the password.
        /// For more information on how to safely handle IAM credentials, see https://docs. aws. amazon.
        /// com/general/latest/gr/aws-access-keys-best-practices. html.
        /// In responses, AWS OpsWorks Stacks returns *****FILTERED***** instead of the actual value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// Revision
        /// The application&#39;s version. AWS OpsWorks Stacks enables you to easily deploy new versions of an
        /// application. One of the simplest approaches is to have branches or revisions in your repository that
        /// represent different versions that can potentially be deployed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Revision")]
        public Union<string, IntrinsicFunction> Revision { get; set; }

        /// <summary>
        /// SshKey
        /// The repository&#39;s SSH key. For more information, see Using Git Repository SSH Keys in the AWS
        /// OpsWorks User Guide. To pass in an SSH key as a parameter, see the following example:
        /// &quot;Parameters&quot; : { &quot;GitSSHKey&quot; : { &quot;Description&quot; : &quot;Change SSH key newlines to commas. &quot;, &quot;Type&quot; :
        /// &quot;CommaDelimitedList&quot;, &quot;NoEcho&quot; : &quot;true&quot; }, . . . &quot;CustomCookbooksSource&quot;: { &quot;Revision&quot; : { &quot;Ref&quot;:
        /// &quot;GitRevision&quot;}, &quot;SshKey&quot; : { &quot;Fn::Join&quot; : [ &quot;\n&quot;, { &quot;Ref&quot;: &quot;GitSSHKey&quot;} ] }, &quot;Type&quot;: &quot;git&quot;, &quot;Url&quot;: {
        /// &quot;Ref&quot;: &quot;GitURL&quot;} } . . .
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SshKey")]
        public Union<string, IntrinsicFunction> SshKey { get; set; }

        /// <summary>
        /// Type
        /// The repository type.
        /// Required: No
        /// Type: String
        /// Allowed values: archive | git | s3 | svn
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Url
        /// The source URL. The following is an example of an Amazon S3 source URL: https://s3. amazonaws.
        /// com/opsworks-demo-bucket/opsworks_cookbook_demo. tar. gz.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

        /// <summary>
        /// Username
        /// This parameter depends on the repository type.
        /// For Amazon S3 bundles, set Username to the appropriate IAM access key ID. For HTTP bundles, Git
        /// repositories, and Subversion repositories, set Username to the user name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

    }
}
