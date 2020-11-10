using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal.Models
{
    public class Generes
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int countSong { get; set; }

        public bool isFavorite { get; set; }

        public List<Song> Songs { get; set; }
    }
}
