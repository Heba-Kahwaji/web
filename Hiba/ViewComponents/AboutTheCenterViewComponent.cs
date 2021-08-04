using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hiba.Services.Contracts;

namespace Hiba.ViewComponents
{
    public class AboutTheCenterViewComponent: ViewComponent
    {
        private readonly IAboutTheCenter _aboutTheCenter;
        public AboutTheCenterViewComponent(IAboutTheCenter aboutTheCenter)
        {
            _aboutTheCenter = aboutTheCenter;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var aboutthecenter = await _aboutTheCenter.AboutTheCenter();
            return View(aboutthecenter);
        }
    }
}
