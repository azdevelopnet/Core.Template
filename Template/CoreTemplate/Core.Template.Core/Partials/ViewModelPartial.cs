﻿using System;
using Core.Template.Core;

namespace Xamarin.Forms.Core
{
    /// <summary>
    /// This partial allows the base view model to be extended with additional properties
    /// </summary>
    public partial class CoreViewModel
    {
        public SomeBusinessLogic SomeLogic
        {
            get
            {
                return CoreDependencyService.GetBusinessLayer<SomeBusinessLogic>();
            }
        }
    }
}
