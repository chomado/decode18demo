using System;
using Prism.Mvvm;
namespace decode18demo
{
    public class AppSettings : BindableBase
    {
        public AppSettings()
        {
        }

        private string backgroundColor;
        private string fontColor;
        private string accentColor;

        public string BackgroundColor
        {
            get => this.backgroundColor;
            set => SetProperty(ref this.backgroundColor, value);
        }
        public string FontColor
        {
            get => this.fontColor;
            set => SetProperty(ref this.fontColor, value);
        }
        public string AccentColor
        {
            get => this.accentColor;
            set => SetProperty(ref this.accentColor, value);
        }

        public static AppSettings Instance { get; } = new AppSettings();


    }
}
