using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinDevSummit.Services;

namespace XamarinDevSummit.Droid.Services
{
    class SoundService : ISoundService
    {

        private readonly MediaPlayer coinPlayer;
        private readonly MediaPlayer powerUpPlayer;
        private readonly MediaPlayer lifePlayer;

        public SoundService()
        {
            coinPlayer = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.Coin);
            powerUpPlayer = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.PowerUp);
            lifePlayer = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.Life);
        }


        public void PlaySound(Sounds sound)
        {
            switch (sound)
            {
                case Sounds.Coin:
                    coinPlayer.Start();
                    break;
                case Sounds.PowerUp:
                    powerUpPlayer.Start();
                    break;
                case Sounds.Life:
                    lifePlayer.Start();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}