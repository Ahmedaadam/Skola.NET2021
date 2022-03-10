using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inlämning3_OOA.Models
{
    public class Music
    {
        [Key]
        public int ID { get; set; }
        public string Song { get; set; }
        public int Grade { get; set; }
        public int DropDate { get; set; }
        public int ArtistID { get; set; }
        public virtual HashSet<Artist> Artists { get; set; }

        public Music()
        {
            this.Artists = new HashSet<Artist>();
        }
        public Music(string song, int grade, int drop)
        {
            Song = song;
            Grade = grade;
            DropDate = drop;
        }
    }
    public class Artist
    {
        public virtual HashSet<Music> Songs { get; set; }
        
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Genre { get; set; }
        public int Age { get; set; }
        public Artist()
        {
            this.Songs = new HashSet<Music>();
        }
        public Artist(string first, string last, string alias, string genre, int age)
        {
            FirstName = first;
            LastName = last;
            Alias = alias;
            Genre = genre;
            Age = age;
        }

    }
}
