using System;
using System.Collections.Generic;

namespace ImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is a name: ");
            var nameChose = Console.ReadLine();
            
            var song = new Song(nameChose, "smith");
            var song2 = song.Artist;

            Console.WriteLine($"This is what you chose {song2}");

            Console.ReadLine();
        }

        public class Song
        {
            // not sure this does anything to make it "required"
            public string Artist { get; set; }
            public string Name { get; set; }

            // Constructor
            public Song(string artist, string name)
            {
                Artist = artist;
                Name = name;
            }

            List<string> goodSongs = new List<string>();
            List<string> allSongs = new List<string>();
        }
    }
}
            




            
            
            




            
