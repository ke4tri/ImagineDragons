using System;
using System.Collections.Generic;
using System.Linq;

namespace ImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is a name: ");
            var nameChose = Console.ReadLine();
            Console.WriteLine("What is a song: ");
            var songChose = Console.ReadLine();
            
            var song = new Song(nameChose, songChose);
            var songArtist = song.Artist;
            var songName = song.Name;

            Console.WriteLine($"This is what you chose {songArtist}, and {songName}");
           
            

            // How do you set this to empty:
            var songListArtistOne = new List<string> { "Good Dude","Love Man" };
            // HARDCODE ADDING SONGS TO songString like below
            songListArtistOne.Add("Yummy");
            songListArtistOne.Add("Newer Song");
            
            // CREATE A DICTIONARY FOR THE ARTIST THAT TAKS PARAMS OF ARTIST
            // AND THEN THE LIST OF THE ARTIST SONGS CREATED ABOVE
            // How do you set this to empty?
            var newSongDictionary = new Dictionary<string, List<string>>
            {
                { "Sammple Artist", songListArtistOne}
            };

            // ADDING A NEW ARTIST AND THE ARTIS LIST OF SONGS
            newSongDictionary.Add("Post Malone", new List<string> { "It was a good year song" });
            // OR
            // newSongDictionary.Add("Post Malone", new List<string>());

            foreach (var(key, value) in newSongDictionary)
            {
                Console.WriteLine($"This is just something to console {key}");

                foreach (var songIn in value)
                {
                    Console.WriteLine(songIn);
                }
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        public class Song
        {
           
            public string Artist { get; set; }
            public string Name { get; set; }

            // Constructor
            public Song(string artist, string name)
            {
                Artist = artist;
                Name = name;
            }

            //List<string> goodSongs = new List<string>();
            //List<string> allSongs = new List<string>();
            //IDictionary<string, string> goodSongs = new Dictionary<string, string>();
            //IDictionary<string, string> allSongs = new Dictionary<string, string>();

            
            //public void SaveToDictionary(string name, string song)
            //{
            //    goodSongs.Add(name, song);
            //}
        }
    }
}
           

            




            
            
            




            
