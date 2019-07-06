using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDevSummit.Services
{
    public enum Sounds
    {
        Coin = 1,
        PowerUp = 2,
        Life = 3
    }

    public interface ISoundService
    {
        void PlaySound(Sounds sound);
    }
}
