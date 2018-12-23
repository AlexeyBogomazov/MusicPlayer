using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Player
    {
        const int MIN_VOLUME = 0;
        const int MAX_VOLUME = 100;

        bool Locked;

        private bool _playing;

        public bool Playing
        {
            get
            {
                return _playing;
            }
        }

        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }

            private set
            {
                if (value < MIN_VOLUME)
                {
                    _volume = MIN_VOLUME;
                }
                else if (value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        public Song[] Songs;

        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Player is locked.");
        }

        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Player is unlocked.");
        }

        public bool Stop()
        {
            if (!Locked)
            {
                _playing = false;

                Console.WriteLine($"Player has stopped.");
                return _playing;
            }
            else
            {
                Console.WriteLine("Player is locked. Cannot stop.");
                return _playing;
            }
            
        }

        public bool Start()
        {
            if (!Locked)
            {
                _playing = true;

                Console.WriteLine($"Player is playing: {Songs[0].Name}.");
                return _playing;
            }
            else
            {
                Console.WriteLine("Player is locked. Cannot play.");
                return _playing;
            }

        }

        public void VolumeUp()
        {
            Volume++;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeChange(int step)
        {
            Volume += step;
        }

       
    }
}
