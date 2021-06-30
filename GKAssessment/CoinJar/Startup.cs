﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddControllersWithViews();
            //services.AddRazorPages();

            // THIS IS IMPORTANT  
            services.AddSingleton<CoinJar>(provider => new CoinJar());
        }
    }
}
