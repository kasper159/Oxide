﻿using Oxide.Core.Plugins;
using System;

namespace Oxide.Game.InterstellarRift
{
    /// <summary>
    /// Responsible for loading Interstellar Rift core plugins
    /// </summary>
    public class InterstellarRiftPluginLoader : PluginLoader
    {
        public override Type[] CorePlugins => new[] { typeof(InterstellarRiftCore) };
    }
}
