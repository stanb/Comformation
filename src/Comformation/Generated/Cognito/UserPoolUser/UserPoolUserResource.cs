using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolUser
{
    /// <summary>
    /// AWS::Cognito::UserPoolUser
    /// The AWS::Cognito::UserPoolUser resource creates an Amazon Cognito user pool user.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html
    /// </summary>
    public class UserPoolUserResource : ResourceBase
    {
        public class UserPoolUserProperties
        {
            /// <summary>
            /// ValidationData
            /// The user's validation data. This is a list of name-value pairs that contain user attributes and
            /// attribute values that you can use for custom validation, such as restricting the types of user
            /// accounts that can be registered. For example, you might choose to allow or disallow user sign-up
            /// based on the user's domain.
            /// To configure custom validation, you must create a Pre Sign-up Lambda trigger for the user pool. The
            /// Lambda trigger receives the validation data and uses it in the validation process. For more
            /// information, see Customizing User Pool Workflows by Using AWS Lambda Triggers in the Amazon Cognito
            /// Developer Guide.
            /// Required: No
            /// Type: List of Amazon Cognito UserPoolUser AttributeType
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-validationdata
            /// </summary>
			public Union<List<AttributeType>, IntrinsicFunction> ValidationData { get; set; }

            /// <summary>
            /// UserPoolId
            /// The ID for the user pool where the user will be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-userpoolid
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// Username
            /// The user name for the user. Username must be unique within the user pool. It must be a UTF-8 string
            /// between 1 and 128 characters. You can't change the username.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-username
            /// </summary>
			public Union<string, IntrinsicFunction> Username { get; set; }

            /// <summary>
            /// MessageAction
            /// Specifies the action you'd like to take for the message. Valid values are RESEND and SUPPRESS.
            /// To resend the invitation message to a user that already exists and reset the expiration limit on the
            /// user's account, set this parameter to RESEND. To suppress sending the message, set it to SUPPRESS.
            /// You can specify only one value.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-messageaction
            /// </summary>
			public Union<string, IntrinsicFunction> MessageAction { get; set; }

            /// <summary>
            /// DesiredDeliveryMediums
            /// Specifies how the welcome message will be sent. For email, specify EMAIL. To use a phone number,
            /// specify SMS. You can specify more than one value. The default value is SMS.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-desireddeliverymediums
            /// </summary>
			public Union<List<string>, IntrinsicFunction> DesiredDeliveryMediums { get; set; }

            /// <summary>
            /// ForceAliasCreation
            /// Use this parameter only if the phone_number_verified attribute or the email_verified attribute is
            /// set to True. Otherwise, it is ignored. The default value is False.
            /// If this parameter is set to True and the phone number or email address specified in the
            /// UserAttributes parameter already exists as an alias with a different user, the API call migrates the
            /// alias from the previous user to the newly created user. The previous user can no longer log in using
            /// that alias.
            /// If this parameter is set to False and the alias already exists, the API throws an
            /// AliasExistsException error.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-forcealiascreation
            /// </summary>
			public Union<bool, IntrinsicFunction> ForceAliasCreation { get; set; }

            /// <summary>
            /// UserAttributes
            /// A list of name-value pairs that contain user attributes and attribute values to be set for the user
            /// that you are creating. You can create a user without specifying any attributes other than Username.
            /// However, any attributes that you specify as required (in CreateUserPool or in the Attributes tab of
            /// the console) must be supplied either by you (in your call to AdminCreateUser) or by the user (when
            /// signing up in response to your welcome message).
            /// Required: No
            /// Type: List of Amazon Cognito UserPoolUser AttributeType
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpooluser.html#cfn-cognito-userpooluser-userattributes
            /// </summary>
			public Union<List<AttributeType>, IntrinsicFunction> UserAttributes { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::UserPoolUser";
        
        public UserPoolUserProperties Properties { get; } = new UserPoolUserProperties();
    }
}
