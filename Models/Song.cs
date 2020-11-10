using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal.Models
{
    public class Song
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string ArtistName { get; set; }
        
        public string Published { get; set; }

        public string countPlay { get; set; }

        public string Description { get; set; }

        public bool isFavorite { get; set; }

        public List<Song> Songs { get; set; }
    }
}
