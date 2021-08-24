using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.Secret
{
    /// <summary>
    /// AWS::SecretsManager::Secret GenerateSecretString
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-secret-generatesecretstring.html
    /// </summary>
    public class GenerateSecretString
    {

        /// <summary>
        /// ExcludeUppercase
        /// Specifies that the generated password should not include uppercase letters. The default behavior is
        /// False, and the generated password can include uppercase letters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeUppercase")]
        public Union<bool, IntrinsicFunction> ExcludeUppercase { get; set; }

        /// <summary>
        /// RequireEachIncludedType
        /// Specifies whether the generated password must include at least one of every allowed character type.
        /// By default, Secrets Manager enables this parameter, and the generated password includes at least one
        /// of every character type.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequireEachIncludedType")]
        public Union<bool, IntrinsicFunction> RequireEachIncludedType { get; set; }

        /// <summary>
        /// IncludeSpace
        /// Specifies that the generated password can include the space character. By default, Secrets Manager
        /// disables this parameter, and the generated password doesn&#39;t include space
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSpace")]
        public Union<bool, IntrinsicFunction> IncludeSpace { get; set; }

        /// <summary>
        /// ExcludeCharacters
        /// A string that excludes characters in the generated password. By default, all characters from the
        /// included sets can be used. The string can be a minimum length of 0 characters and a maximum length
        /// of 7168 characters.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 4096
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeCharacters")]
        public Union<string, IntrinsicFunction> ExcludeCharacters { get; set; }

        /// <summary>
        /// GenerateStringKey
        /// The JSON key name used to add the generated password to the JSON structure specified by the
        /// SecretStringTemplate parameter. If you specify this parameter, then you must also specify
        /// SecretStringTemplate.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 65536
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GenerateStringKey")]
        public Union<string, IntrinsicFunction> GenerateStringKey { get; set; }

        /// <summary>
        /// PasswordLength
        /// The desired length of the generated password. The default value if you do not include this parameter
        /// is 32 characters.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PasswordLength")]
        public Union<int, IntrinsicFunction> PasswordLength { get; set; }

        /// <summary>
        /// ExcludePunctuation
        /// Specifies that the generated password should not include punctuation characters. The default if you
        /// do not include this switch parameter is that punctuation characters can be included.
        /// The following are the punctuation characters that can be included in the generated password if you
        /// don&#39;t explicitly exclude them with ExcludeCharacters or ExcludePunctuation:
        /// ! &quot; # $ % &amp;amp; &#39; ( ) * + , - . / : ; &amp;lt; = &amp;gt; ? @ [ \ ] ^ _ ` { | } ~
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludePunctuation")]
        public Union<bool, IntrinsicFunction> ExcludePunctuation { get; set; }

        /// <summary>
        /// ExcludeLowercase
        /// Specifies the generated password should not include lowercase letters. By default, ecrets Manager
        /// disables this parameter, and the generated password can include lowercase False, and the generated
        /// password can include lowercase letters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeLowercase")]
        public Union<bool, IntrinsicFunction> ExcludeLowercase { get; set; }

        /// <summary>
        /// SecretStringTemplate
        /// (Optional) Specifies text data that you want to encrypt and store in this new version of the secret.
        /// Either GenerateSecretString or SecretString must have a value, but not both. They cannot both be
        /// empty.
        /// If you create a secret by using the Secrets Manager console then Secrets Manager puts the protected
        /// secret text in only the SecretString parameter. The Secrets Manager console stores the information
        /// as a JSON structure of key/value pairs that the Lambda rotation function knows how to parse.
        /// For storing multiple values, we recommend that you use a JSON text string argument and specify
        /// key/value pairs. For information on how to format a JSON parameter for the various command line tool
        /// environments, see Using JSON for Parameters in the AWS CLI User Guide. For example:
        /// {&quot;username&quot;:&quot;bob&quot;,&quot;password&quot;:&quot;abc123xyz456&quot;}
        /// If your command-line tool or SDK requires quotation marks around the parameter, you should use
        /// single quotes to avoid confusion with the double quotes required in the JSON text.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 65536
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretStringTemplate")]
        public Union<string, IntrinsicFunction> SecretStringTemplate { get; set; }

        /// <summary>
        /// ExcludeNumbers
        /// Specifies that the generated password should not include digits. The default if you do not include
        /// this switch parameter is that digits can be included.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeNumbers")]
        public Union<bool, IntrinsicFunction> ExcludeNumbers { get; set; }

    }
}
