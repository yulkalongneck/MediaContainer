using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaContainer.Models
{
    public class MediaContainer
    {
        // Fields, properties (will be inherited by Playlist and Folder)

        public MediaContainer()
        {
            ID = null;
            UserID = null;
            Title = null;
            Description = null;
            Type = "MediaContainer";
        }

        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? UserID { get; set; }
        public int? ID { get; set; }

        //nullable epoch dateCreated and dateModified
        public long? DateCreated { get; set; }
        public long? DateModified { get; set; }
    }
}