using System;
using System.Reflection;

namespace HAN.OOSE.Semesterbeheer.Applicatie.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}