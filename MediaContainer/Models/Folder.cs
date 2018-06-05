using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaContainer.Models
{
    public class Folder : MediaContainer
    {
        // Fields, properties
        public Folder()
        {
            ID = null;
            Title = null;
            Description = null;
            base.Type = "Folder";
        }

        public List<MusicTrack> childrenMusicTracks { get; set; }
        public List<Lyrics> childrenLyrics { get; set; }

        public class Lyrics
        {
            public Lyrics()
            {
                ID = null;
                Artist = null;
                Title = null;
                DateCreated = null;
                DateModified = null;
            }
            public int? ID { get; set; }
            public string Artist { get; set; }
            public string Title { get; set; }
            //nullable epoch dateCreated and dateModified
            public long? DateCreated { get; set; }
            public long? DateModified { get; set; }

        }
    }

    
}