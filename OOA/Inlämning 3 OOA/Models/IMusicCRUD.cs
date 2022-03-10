using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3_OOA.Models
{
    interface IMusicCRUD
    {
        void Create(Music music);
        void Create(List<Music> songs);
        void Delete(int ID);
        void Delete(string song);
        List<Music> List(string filter = "name");
        List<Artist> List(int ID);
        Music Read(int Id);
        Artist Read(string alias);
        void Update(Music music);
        void Clear();
        void Create(Artist artist);
        void Create(List<Artist> artists);
        void Update(Artist artist);
        Music GetArtist(int songId, int artistId);
        void SetArtist(int songId, int artistId);
    }
}
