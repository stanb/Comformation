using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS::OpsWorks::App
    /// Defines an AWS OpsWorks app for an AWS OpsWorks stack. The app specifies the code that you want to run on an
    /// application server.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-app.html
    /// </summary>
    public class AppResource : ResourceBase
    {
        public class AppProperties
        {
            /// <summary>
            /// AppSource
            /// The information required to retrieve an app from a repository.
            /// Required: No
            /// Type: AWS OpsWorks Source Type
            /// Update requires: No interruption
            /// </summary>
			public Source AppSource { get; set; }

            /// <summary>
            /// Attributes
            /// One or more user-defined key-value pairs to be added to the app attributes bag.
            /// Required: No
            /// Type: A list of key-value pairs
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

            /// <summary>
            /// DataSources
            /// A list of databases to associate with the AWS OpsWorks app.
            /// Required: No
            /// Type: List of AWS OpsWorks App DataSource
            /// Update requires: No interruption
            /// </summary>
			public List<DataSource> DataSources { get; set; }

            /// <summary>
            /// Description
            /// A description of the app.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Domains
            /// The app virtual host settings, with multiple domains separated by commas. For example, &#39;www.
            /// example. com, example. com&#39;.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Domains { get; set; }

            /// <summary>
            /// EnableSsl
            /// Whether to enable SSL for this app.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableSsl { get; set; }

            /// <summary>
            /// Environment
            /// The environment variables to associate with the AWS OpsWorks app.
            /// Required: No
            /// Type: List of AWS OpsWorks App Environment
            /// Update requires: No interruption
            /// </summary>
			public List<EnvironmentVariable> Environment { get; set; }

            /// <summary>
            /// Name
            /// The name of the AWS OpsWorks app.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Shortname
            /// The app short name, which is used internally by AWS OpsWorks and by Chef recipes.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Shortname { get; set; }

            /// <summary>
            /// SslConfiguration
            /// The SSL configuration
            /// Required: No
            /// Type: AWS OpsWorks SslConfiguration Type
            /// Update requires: No interruption
            /// </summary>
			public SslConfiguration SslConfiguration { get; set; }

            /// <summary>
            /// StackId
            /// The ID of the AWS OpsWorks stack to associate this app with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StackId { get; set; }

            /// <summary>
            /// Type
            /// The app type. Each supported type is associated with a particular layer. For more information, see
            /// CreateApp in the AWS OpsWorks Stacks API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

        }
    
        public string Type { get; } = "AWS::OpsWorks::App";
        
        public AppProperties Properties { get; } = new AppProperties();

    }
}
