using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaContainer.Models
{
    public class Playlist : MediaContainer
    {
        // Fields, properties
        public Playlist()
        {
            Title = null;
            Description = null;
            base.Type = "Playlist";
        }

        public List<MusicTrack> childrenMusicTracks { get; set; }
    }

    
}