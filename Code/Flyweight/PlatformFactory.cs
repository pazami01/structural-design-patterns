using System;
using System.Collections.Generic;

namespace Flyweight
{
    public static class PlatformFactory
    {
        private static Dictionary<string, IPlatform> _platforms = new Dictionary<string, IPlatform>();

        public static IPlatform PlatformInstance(string name)
        {
            IPlatform platform;
            bool hasPlatform = _platforms.TryGetValue(name, out platform);

            if (!hasPlatform)
            {
                platform = GetNewPlatform(name);
                _platforms.Add(name, platform);
            }

            return platform;
        }

        private static IPlatform GetNewPlatform(string name)
        {

            IPlatform platform = name switch
            {
                "C" => new CPlatform(),
                "JAVA" => new JavaPlatform(),
                "RUBY" => new RubyPlatform(),
                "SCALA" => new ScalaPlatform(),
                _ => throw new ArgumentException($"There is no platform available with the name {name}")
            };

            return platform;
        }
    }
}