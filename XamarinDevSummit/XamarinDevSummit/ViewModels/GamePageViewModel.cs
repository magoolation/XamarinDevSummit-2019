using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using XamarinDevSummit.Services;

namespace XamarinDevSummit.ViewModels
{
    public class GamePageViewModel : ViewModelBase
    {
        private readonly ISoundService soundService;

        public GamePageViewModel(INavigationService navigationService, ISoundService soundService) : base(navigationService)
        {
            Title = "End Game";

            this.soundService = soundService;

            CoinCommand = new DelegateCommand(CoinClicked);
            PowerUpCommand = new DelegateCommand(PowerUpClicked);
            LifeCommand = new DelegateCommand(LifeClicked);
        }

        private void LifeClicked() => this.soundService.PlaySound(Sounds.Life);

        private void PowerUpClicked() => this.soundService.PlaySound(Sounds.PowerUp);

        private void CoinClicked() => this.soundService.PlaySound(Sounds.Coin);

        public ICommand CoinCommand { get; }
        public ICommand PowerUpCommand { get; }
        public ICommand LifeCommand { get; }
    }
}
