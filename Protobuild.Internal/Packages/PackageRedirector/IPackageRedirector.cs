﻿namespace Protobuild
{
    public interface IPackageRedirector
    {
        string RedirectPackageUrl(string url);

        void RegisterLocalRedirect(string original, string replacement);

        string GetRedirectionArguments();
    }
}

