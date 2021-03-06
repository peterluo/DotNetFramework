﻿using System.Configuration;

namespace DotNet.Web.StateManagement
{
    public class ProviderConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty( "providers" )]
        public ProviderCollection Providers
        {
            get
            {
                return (ProviderCollection)base["providers"];
            }
        }

        [StringValidator( MinLength = 1 )]
        [ConfigurationProperty("defaultProvider", DefaultValue = "CookieStateProvider")]
        public string DefaultProvider
        {
            get
            {
                return (string)base["defaultProvider"];
            }
        }
    }
}
