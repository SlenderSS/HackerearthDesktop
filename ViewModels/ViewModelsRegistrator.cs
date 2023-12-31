﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.ViewModels
{
    internal static class ViewModelsRegistrator
    {
        public static IServiceCollection RegisterViewModels(this IServiceCollection services) =>  services
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<CodeEditorViewModel>()
            ;
            
       
    }
}
