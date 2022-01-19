using Inlämning3_OOA.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3_OOA.Models
{
    public class MusicListLogic : IMusicCRUD
    {

        public void Create(Music music)
        {
            using (var db = new MusicListContext())
            {
                db.Songs.Add(music);
                db.SaveChanges();
            }
        }

        public void Create(List<Music> songs)
        {
            using (var db = new MusicListContext())
            {
                db.Songs.AddRange(songs);
                db.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var db = new MusicListContext())
            {
                var selectedSong = db.Songs.FirstOrDefault(x => x.ID == Id);
                if (selectedSong == null)
                {
                    return;
                }
                db.Remove(selectedSong);

                db.SaveChanges();
            }
        }
        public void Delete(string song)
        {
            using (var db = new MusicListContext())
            {
                var selectedSong = db.Songs.FirstOrDefault(x => x.Song == song);
                if (selectedSong == null)
                {
                    return;
                }
                db.Remove(selectedSong);

                db.SaveChanges();
            }
        }

        public List<Music> List(string  Song)
        {
            using (var db = new MusicListContext())
            {
               return db.Songs.OrderBy(x => x.Song).ToList();
            }
        }

        public Music Read(int Id)
        {
            using (var db = new MusicListContext())
            {
                return db.Songs.FirstOrDefault(x => x.ID == Id);
            }
        }

        public void Update(Music music)
        {
            using (var db = new MusicListContext())
            {
                var selectedSong = db.Songs.FirstOrDefault(x => x.ID == music.ID);
                if (selectedSong == null)
                {
                    return;
                }
                selectedSong.Song = music.Song;
                selectedSong.Grade = music.Grade;  
                selectedSong.DropDate = music.DropDate;
                selectedSong.ArtistID = music.ArtistID;
                db.SaveChanges();
            }
        }
        public void Clear()
        {
            using (var db = new MusicListContext())
            {
                db.Songs.RemoveRange(db.Songs);
                db.Artists.RemoveRange(db.Artists);
                db.SaveChanges();
            }
        }

        public void Create(Artist artist)
        {
            using (var db = new MusicListContext())
            {
                db.Artists.Add(artist);
                db.SaveChanges();
            }
        }

        public void Create(List<Artist> artists)
        {
            using (var db = new MusicListContext())
            {
                db.Artists.AddRange(artists);
                db.SaveChanges();
            }
        }
        public List<Artist> List(int ID)
        {
            using (var db = new MusicListContext())
            {
                return db.Artists.OrderBy(x => x.ID).ToList();
            }
        }

        public void Update(Artist artist)
        {
            using (var db = new MusicListContext())
            {
                var selectedArtist = db.Artists.FirstOrDefault(x => x.ID == artist.ID);
                if (selectedArtist == null)
                {
                    return;
                }
                selectedArtist.ID = artist.ID;
                selectedArtist.FirstName = artist.FirstName;
                selectedArtist.LastName = artist.LastName;
                selectedArtist.Alias = artist.Alias;
                selectedArtist.Genre = artist.Genre;
                selectedArtist.Age = artist.Age;
                db.SaveChanges();

            }
        }

        public Music GetArtist(int ID, int ArtistID)
        {
            var song = Read(ID);
            if (song == null || song.ArtistID == null)
            {
                return null;
            }
            return Read((int)song.ArtistID);
        }

        public void SetArtist(int songId, int ArtistId)
        {
            var song = Read(songId);
            var singer = Read(ArtistId);

            if (song == null || singer == null)
            {
                return;
            }

            using (var db = new MusicListContext())
            {
                var person = db.Songs.FirstOrDefault(x => x.ID == songId);
                person.ArtistID = ArtistId;
                db.SaveChanges();
            }
        }

        public Artist Read(string alias)
        {
            using (var db = new MusicListContext())
            {
                return db.Artists.FirstOrDefault(x => x.Alias == alias);
            }
        }
    }
}
