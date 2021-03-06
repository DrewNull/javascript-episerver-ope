﻿namespace ClassicalMusicShop.Website.Features.SheetMusic
{
    using Infrastructure.AppMode;

    public static class SheetMusicViewPathHelper
    {
        public static string GetViewPath(AppMode appMode)
        {
            string pathBase = "~/Features/SheetMusic/Views";

            switch (appMode)
            {
                default:
                case AppMode.Mvc:
                    return $"{pathBase}/Index.cshtml";

                case AppMode.Angular:
                    return $"{pathBase}/IndexAngular.cshtml";

                case AppMode.Vue:
                    return $"{pathBase}/IndexVue.cshtml";

                case AppMode.React:
                    return $"{pathBase}/IndexReact.cshtml";
            }
        }
    }
}