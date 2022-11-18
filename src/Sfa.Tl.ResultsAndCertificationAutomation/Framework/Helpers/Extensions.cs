using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

public static class Extensions
{
    public static string FullUrl(this string pagePath)
    {
        return string.Concat(StartPage.StartPageUrl, pagePath);
    }

    public static string GetIdByName(this string name)
    {
        return name.Replace(" ", "").ToLower();
    }
}