using Inlämning3_OOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3_OOA
{
    public static class Setup
    {
        public static void Init()
        {
            var context = new MusicListLogic();
            // clear database
            context.Clear();
            //create artists
            var singers = new List<Artist>
            {
                new Artist ("Aubrey", "Graham", "Drake", "Hiphop", 32),
                new Artist ("Taurus", "Barlett", "Polo G", "Rap", 23),
                new Artist ("Durk", "Banks", "Lil Durk", "Drill", 29),
                new Artist ("Curtis", "Jackson", "50 Cent", "Rap", 46)

            };
            context.Create(singers);
            
            // Create top5 music list
            var top5List = new List<Music>
            {
                new Music ("Do not disturb", 10, 2017),
                new Music ("RAPSTAR", 8, 2021),
                new Music ("All love", 7, 2020),
                new Music ("Many men", 9, 2003),
                new Music ("One dance", 9, 2016),
            };

            context.Create(top5List);
           
            // Add singer to each song

            var drake = context.Read("Drake");
            var polog = context.Read("Polo G");
            var lildurk = context.Read("Lil Durk");
            var fiftycent = context.Read("50 Cent");

            foreach (var song in top5List)
            {
                if(song.Song == "Do not disturb")
                {
                    context.SetArtist(song.ID, drake.ID);
                }
                if(song.Song == "Rapstar")
                {
                    context.SetArtist(song.ID, polog.ID);
                }
                if(song.Song == "All love")
                {
                    context.SetArtist(song.ID, lildurk.ID);
                }
                if(song.Song == "Many men")
                {
                    context.SetArtist(song.ID, fiftycent.ID);
                }
                if(song.Song == "One dance")
                {
                    context.SetArtist(song.ID, drake.ID);
                }
            }
        }
    }
}
