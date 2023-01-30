using GherkinSpec.TestModel;
using TechTalk.SpecFlow;

namespace GherkinSpec.SpecFlowBindingsExample.Tests;

public class SpecFlowStepAttributeMatchExpressionSelector : IStepAttributeMatchExpressionSelector
{
    public string SelectMatchExpression(object attribute)
    {
        return ((StepDefinitionBaseAttribute)attribute).Regex;
    }
}