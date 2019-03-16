using System;
using System.Collections.Generic;
using System.Linq;

namespace ImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the name of an artist you like? : ");
            var nameChose = Console.ReadLine();
            Console.WriteLine("What is a song of theres to add to a list? : ");
            var songChose = Console.ReadLine();

            ////////////////////////////////////// List /////////////////////////
            IList<string> postMalone = new List<string>();
            postMalone.Add("Better Now");
            postMalone.Add("Congradulations");

            IList<string> eltonJohn = new List<string>();
            postMalone.Add("Tiny Dancer");
            postMalone.Add("Yellow Brick Road");

            List<string> artistSongLists = new List<string>();
            artistSongLists.AddRange(postMalone);
            artistSongLists.AddRange(eltonJohn);

            /////////////////////////////////////////////////////////////////////
           
            var song = new Song(nameChose, songChose);
            var songArtist = song.Artist;
            var songName = song.Name;

            //Console.WriteLine($"This is what you chose {songArtist}, and {songName}");

            //////////////////////////////// List of songs for indeivdual artis///
            var songListSample = new List<string> { "Sample This Song", "This one Too" };
            songListSample.Add("For good messure");
            songListSample.Add("Here is another one");
            var songListPost = new List<string> { "Good Dude","Love Man" };
            songListPost.Add("Yummy");
            songListPost.Add("Newer Song");
            var songListWayne = new List<string> { "One for the Mony", "Love That Woman" };
            songListWayne.Add("One more for the road Dude");

            // How do you set this to empty?
            var newSongDictionary = new Dictionary<string, List<string>>
            {
                //hardcoded this artist
                { "Sammple Artist", songListSample}
            };

            // Below adds the songlst to the above dictionary along with the name of artist
            // Commented the newSongDictionayr.Add below out becuase it was already hardcoded in
            // side the dictionary 
            // newSongDictionary.Add("Sample Artist", songListSample);
            newSongDictionary.Add("Wayne Collier", songListWayne);
            newSongDictionary.Add("Post Malone", songListPost);

            foreach (var(key, value) in newSongDictionary)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"This should be an artist name {key} ");

                foreach (var songIn in value)
                {
                    Console.WriteLine($"This should be a song {songIn}");
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
        }

        //public class AddList
        //{
        //    public string Artist { get; set; }
        //    public string Name { get; set; }

        //    // Constructor
        //    public AddList(string artist, string song)
        //    {
        //        artist.Add(song);
        //    }
        //}
    }
}









           

            
           

            




            
            
            




            
