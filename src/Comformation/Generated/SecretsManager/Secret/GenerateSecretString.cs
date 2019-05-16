using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.Secret
{
    /// <summary>
    /// AWS::SecretsManager::Secret GenerateSecretString
    /// Use the GenerateSecretStringproperty as part of the AWS::SecretsManager::Secret resource type to dynamically
    /// generate a random text string to use as a password. It is an alternative to hardcoding a password directly in
    /// the SecretString property. When you generate a AWS::SecretsManager::Secret resource type, you must include one
    /// or the other, but not both.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-secret-generatesecretstring.html
    /// </summary>
    public class GenerateSecretString
    {

        /// <summary>
        /// ExcludeUppercase
        /// Specifies that the generated password should not include uppercase letters. The default if you do
        /// not include this switch parameter is False, and the generated password can include uppercase
        /// letters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeUppercase")]
        public Union<bool, IntrinsicFunction> ExcludeUppercase { get; set; }

        /// <summary>
        /// RequireEachIncludedType
        /// Specifies whether the generated password must include at least one of every allowed character type.
        /// If you don&#39;t include this switch, the default value is True, and the generated password includes at
        /// least one of every character type.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequireEachIncludedType")]
        public Union<bool, IntrinsicFunction> RequireEachIncludedType { get; set; }

        /// <summary>
        /// IncludeSpace
        /// Specifies that the generated password can include the space character. The default if you do not
        /// include this switch parameter is False, and the generated password doesn&#39;t include space characters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeSpace")]
        public Union<bool, IntrinsicFunction> IncludeSpace { get; set; }

        /// <summary>
        /// ExcludeCharacters
        /// A string that includes characters that should not be included in the generated password. The default
        /// is that all characters from the included sets can be used. The string can be a minimum length of 0
        /// characters and a maximum length of 7168 characters.
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
        /// The JSON key name that&#39;s used to add the generated password to the JSON structure specified by the
        /// SecretStringTemplateparameter. If you specify this parameter, then you must also specify
        /// SecretStringTemplate.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 7168
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
        /// Specifies that the generated password should not include lowercase letters. The default if you don&#39;t
        /// include this switch parameter is False, and the generated password can include lowercase letters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeLowercase")]
        public Union<bool, IntrinsicFunction> ExcludeLowercase { get; set; }

        /// <summary>
        /// SecretStringTemplate
        /// A properly structured JSON string that the generated password can be added to. If you specify this
        /// parameter, then you must also specify GenerateStringKey. That key is combined with the generated
        /// random string and inserted into the JSON structure that&#39;s specified by this parameter. The merged
        /// JSON string is returned as the completed SecretStringof the secret. The default if you don&#39;t include
        /// this parameter is that the generated random password string is returned by itself, and isn&#39;t embeded
        /// in a JSON structure.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 7168
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretStringTemplate")]
        public Union<string, IntrinsicFunction> SecretStringTemplate { get; set; }

        /// <summary>
        /// ExcludeNumbers
        /// Specifies that the generated password should not include digits. The default if you don&#39;t include
        /// this switch parameter is False, and the generated password can include digits.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeNumbers")]
        public Union<bool, IntrinsicFunction> ExcludeNumbers { get; set; }

    }
}
