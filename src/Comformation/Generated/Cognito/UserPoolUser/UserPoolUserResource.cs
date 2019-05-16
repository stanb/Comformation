using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUser
{
    /// <summary>
    /// AWS::Cognito::UserPoolUser
    /// The AWS::Cognito::UserPoolUser resource creates an Amazon Cognito user pool user.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html
    /// </summary>
    public class UserPoolUserResource : ResourceBase
    {
        public class UserPoolUserProperties
        {
            /// <summary>
            /// ValidationData
            /// The user&#39;s validation data. This is an array of name-value pairs that contain user attributes and
            /// attribute values that you can use for custom validation, such as restricting the types of user
            /// accounts that can be registered. For example, you might choose to allow or disallow user sign-up
            /// based on the user&#39;s domain.
            /// To configure custom validation, you must create a Pre Sign-up Lambda trigger for the user pool as
            /// described in the Amazon Cognito Developer Guide. The Lambda trigger receives the validation data and
            /// uses it in the validation process.
            /// The user&#39;s validation data is not persisted.
            /// Required: No
            /// Type: List of AttributeType
            /// Update requires: Replacement
            /// </summary>
			public List<AttributeType> ValidationData { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID for the user pool where the user will be created.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// Username
            /// The username for the user. Must be unique within the user pool. Must be a UTF-8 string between 1 and
            /// 128 characters. After the user is created, the username cannot be changed.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Username { get; set; }

            /// <summary>
            /// MessageAction
            /// Set to &quot;RESEND&quot; to resend the invitation message to a user that already exists and reset the
            /// expiration limit on the user&#39;s account. Set to &quot;SUPPRESS&quot; to suppress sending the message. Only one
            /// value can be specified.
            /// Required: No
            /// Type: String
            /// Allowed Values: RESEND | SUPPRESS
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MessageAction { get; set; }

            /// <summary>
            /// DesiredDeliveryMediums
            /// Specify &quot;EMAIL&quot; if email will be used to send the welcome message. Specify &quot;SMS&quot; if the phone number
            /// will be used. The default value is &quot;SMS&quot;. More than one value can be specified.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> DesiredDeliveryMediums { get; set; }

            /// <summary>
            /// ForceAliasCreation
            /// This parameter is only used if the phone_number_verified or email_verified attribute is set to True.
            /// Otherwise, it is ignored.
            /// If this parameter is set to True and the phone number or email address specified in the
            /// UserAttributes parameter already exists as an alias with a different user, the API call will migrate
            /// the alias from the previous user to the newly created user. The previous user will no longer be able
            /// to log in using that alias.
            /// If this parameter is set to False, the API throws an AliasExistsException error if the alias already
            /// exists. The default value is False.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> ForceAliasCreation { get; set; }

            /// <summary>
            /// UserAttributes
            /// An array of name-value pairs that contain user attributes and attribute values to be set for the
            /// user to be created. You can create a user without specifying any attributes other than Username.
            /// However, any attributes that you specify as required (in API_CreateUserPool or in the Attributes tab
            /// of the console) must be supplied either by you (in your call to AdminCreateUser) or by the user
            /// (when he or she signs up in response to your welcome message).
            /// For custom attributes, you must prepend the custom: prefix to the attribute name.
            /// To send a message inviting the user to sign up, you must specify the user&#39;s email address or phone
            /// number. This can be done in your call to AdminCreateUser or in the Users tab of the Amazon Cognito
            /// console for managing your user pools.
            /// In your call to AdminCreateUser, you can set the email_verified attribute to True, and you can set
            /// the phone_number_verified attribute to True. (You can also do this by calling
            /// API_AdminUpdateUserAttributes. )
            /// email: The email address of the user to whom the message that contains the code and username will be
            /// sent. Required if the email_verified attribute is set to True, or if &quot;EMAIL&quot; is specified in the
            /// DesiredDeliveryMediums parameter. phone_number: The phone number of the user to whom the message
            /// that contains the code and username will be sent. Required if the phone_number_verified attribute is
            /// set to True, or if &quot;SMS&quot; is specified in the DesiredDeliveryMediums parameter.
            /// Required: No
            /// Type: List of AttributeType
            /// Update requires: Replacement
            /// </summary>
			public List<AttributeType> UserAttributes { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolUser";

        public UserPoolUserProperties Properties { get; } = new UserPoolUserProperties();

    }
}
