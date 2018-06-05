using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaContainer.Models
{
    public class MusicTrack
    {
        public MusicTrack()
        {
            ID = null;
            Title = null;
            Duration = 0;
            DateCreated = null;
            DateModified = null;
        }
        public int? ID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public long Duration { get; set; }

        //nullable epoch dateCreated and dateModified
        public long? DateCreated { get; set; }
        public long? DateModified { get; set; }
    }
}