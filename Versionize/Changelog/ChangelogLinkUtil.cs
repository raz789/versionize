using HandlebarsDotNet;

using Version = NuGet.Versioning.SemanticVersion;

namespace Versionize.Changelog;

internal class ChangelogLinkUtil
{
    public static string CreateCompareUrl(
        string compareUrlFormat,
        string organization,
        string repository,
        Version currentTag,
        Version previousTag)
    {
        var template = Handlebars.Compile(compareUrlFormat);
        var data = new
        {
            organization,
            repository,
            currentTag,
            previousTag,
        };

        return template(data);
    }
}
