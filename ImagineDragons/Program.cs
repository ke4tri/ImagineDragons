using System;
using System.Collections.Generic;

namespace ImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {

            
            


            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("We are going to add some songs");
            Console.WriteLine("Name an artist : ");
            Console.ReadLine();
            var userArtistInput = Console.ReadLine();
            Console.WriteLine("Name a song : ");
           
            var userNameInput = Console.ReadLine();
            var song = new Song(userArtistInput, userNameInput);


            Console.WriteLine($"This is what you chose {song}");

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
        }
    }
}


            
