using Prism.Mvvm;
using Reactive;
using Reactive.Bindings;
using Reactive.Bindings.Binding;
using Reactive.Bindings.Extensions;
using Reactive.Bindings.Helpers;
using Reactive.Bindings.Interactivity;
using Reactive.Bindings.Notifiers;
using Reactive.Bindings.ObjectExtensions;
using System;
using System.Linq;
using System.Reactive.Linq;

namespace PrismApp1.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// 
        /// </summary>
        private string _title = "Prism Application";

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public MainWindowViewModel()
        {
            RpTextBox1.Value = "";
            InpuText = this.RpTextBox1
                .Delay(TimeSpan.FromSeconds(1))
                .Select(x => x.ToUpper())
                .ToReactiveProperty();
            RpTextBox1.Value = "aaa";
        }

        /// <summary>
        /// 
        /// </summary>
        public ReactiveProperty<string> RpTextBox1 { get; } = new ReactiveProperty<string>();

        /// <summary>
        /// 
        /// </summary>
        public ReactiveProperty<string> InpuText { get; } = new ReactiveProperty<string>();
    }
}
