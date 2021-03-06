using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenRasta.Wrap.Dependencies
{
    public class WrapDependency
    {
        public string Name { get; set; }
        public ICollection<VersionVertice> VersionVertices { get; set; }

        public bool IsFulfilledBy(Version version)
        {
            return VersionVertices.All(x => x.IsCompatibleWith(version));
        }
        public override string ToString()
        {
            return Name + " " + string.Join(" and ", VersionVertices.Select(x => x.ToString()).ToArray());
        }
    }
}