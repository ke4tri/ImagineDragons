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
            song.SaveToDictionary(songArtist, songName);
            
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
            IDictionary<string, string> goodSongs = new Dictionary<string, string>();
            IDictionary<string, string> allSongs = new Dictionary<string, string>();

            
            public void SaveToDictionary(string name, string song)
            {
                goodSongs.Add(name, song);
            }
        }
    }
}
           

            




            
            
            




            
