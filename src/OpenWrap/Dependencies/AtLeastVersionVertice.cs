using System;

namespace OpenRasta.Wrap.Dependencies
{
    public class AtLeastVersionVertice : VersionVertice
    {
        public AtLeastVersionVertice(Version version)
            : base(version)
        {
        }
        public override bool IsCompatibleWith(Version version)
        {
            return (Version.Major == version.Major
                    && Version.Minor == version.Minor
                    && Version.Build <= version.Build)
                   ||
                   (Version.Major == version.Major
                    && Version.Minor < version.Minor)
                   ||
                   (Version.Major < version.Major);
        }
        public override string ToString()
        {
            return ">= " + Version;
        }
    }
}