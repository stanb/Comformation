![AWS CloudFormation](logo.png)
# Comformation.NET
[![NuGet](https://img.shields.io/nuget/v/Comformation.svg)](https://www.nuget.org/packages/Comformation/) [![Join the chat at https://gitter.im/Comformation-net/Lobby](https://badges.gitter.im/Comformation-net/Lobby.svg)](https://gitter.im/Comformation-net/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Build status](https://ci.appveyor.com/api/projects/status/qnvb9pkepbu4lrqq/branch/master?svg=true)](https://ci.appveyor.com/project/stanb/comformation/branch/master)

### Compose AWS CloudFormation templates with .NET

This library helps you to compose AWS CloudFormation templates with C#.  
It supports __ALL__ resources available in AWS CloudFormation templates.  
Supports Intrinsic Functions.  
All properties are strong typed. No open _dynamic_ or _object_ types. Allowed property types validated in compile time.  
Based on official AWS CloudFormation templates specification.  

### Show me the code
This is a sample of Comformation library usage.  
The generated template plays arround mappings, input and output parameters.  
The template creates S3 bucket whose name generated using combination of several intrinsic functions.  
For a full code sample see [CreateStackTest.cs](src/Comformation.Tests/CreateStackTest.cs)

Install Nuget [package](https://www.nuget.org/packages/Comformation/)
```
Install-Package Comformation
```
then:
```charp
var template = new Template
{
    Description = "Test comformation",
    Parameters = new Parameters
    {
        new Parameter
        {
            LogicalId = "Param1",
            Type = ParameterType.String,
            Default = "Value1",
            Description = "Parameter 1",
        },
        new Parameter
        {
            LogicalId = "Param2",
            Type = ParameterType.Number,
            AllowedValues = new object [] { 1, 2 },
            Description = "Parameter 2",
        }
    },
    Resources = new Resources
    {
        new BucketResource
        {
            LogicalId = "MyBucket",
            Properties =
            {
                // resource name build using intrinsic functions and based on input parameters and mapping
                BucketName = Fn.Sub($"test-bucket-${{sufix}}-{Guid.NewGuid()}",
                    new Sub.Item("sufix", Fn.FindInMap("BucketSufix", Fn.Ref(PseudoParameter.Region), Fn.Ref("Param2")))),
                Tags = new List<Tag>
                {
                    new Tag
                    {
                        Key = "Project", Value = "Comformation"
                    }
                }
            }
        }
    },
    Mappings = new Mappings
    {
        new Mapping
        {
            Name = "BucketSufix",
            Regions =
            {
                new RegionMap
                {
                    Region = RegionEndpoint.EUWest1,
                    Map = { { "1", "ireland-1" }, {"2", "ireland-2"} }
                },
                new RegionMap
                {
                    Region = RegionEndpoint.EUWest2,
                    Map = { { "1", "london-1" }, { "2", "london-2"} }
                }
            }
        }
    },
    Outputs = new Outputs
    {
        // output based on input parameter
        new Output
        {
            Description = "Input Parameter 1",
            LogicalId = "Input1",
            Value = Fn.Ref("Param1")
        },
        // output based on input parameter
        new Output
        {
            Description = "Input Parameter 2",
            LogicalId = "Input2",
            Value = Fn.Ref("Param2")
        },
        // output based on pseudo parameter - region where stack run
        new Output
        {
            LogicalId = "Region",
            Description = "Region",
            Value = Fn.Ref(PseudoParameter.Region)
        },
        // output based on pseudo parameter - created stack id
        new Output
        {
            LogicalId = "StackId",
            Description = "Stack Id",
            Value = Fn.Ref(PseudoParameter.StackId)
        },
        // output based on pseudo parameter - created stack name
        new Output
        {
            LogicalId = "StackName",
            Description = "Stack Name",
            Value = Fn.Ref(PseudoParameter.StackName)
        },
        // output based on created resource
        new Output
        {
            LogicalId = "CreatedBucket",
            Description = "Name of created bucket",
            Value = Fn.Ref("MyBucket")
        },
        // output based on input param and mapping
        new Output
        {
            LogicalId = "Sufix",
            Description = "Bucket name sufix",
            Value = Fn.FindInMap("BucketSufix", Fn.Ref(PseudoParameter.Region), Fn.Ref("Param2"))
        }
    }
};

var request = new CreateStackRequest
{
    StackName = "ComformationTestSimpleTemplate",
    TemplateBody = template.ToString(),
    Parameters = new List<Amazon.CloudFormation.Model.Parameter>
    {
        new Amazon.CloudFormation.Model.Parameter
        {
            ParameterKey = "Param2",
            ParameterValue = "2"
        }
    },
};

// Create stack
var cloudformation = new AmazonCloudFormationClient(RegionEndpoint.EUWest1);
var createResponse = await cloudformation.CreateStackAsync(request);
```
