using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Songs
{
    class Program
    {
        static void Main()
        {
            int numberOfSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSong; i++)
            {
                string[] data = Console.ReadLine().Split("_").ToArray();

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            List<Song> filteredSongs = new List<Song>();

            string typeList = Console.ReadLine();

            if (typeList != "all")
            {
                filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();
            }
            else
            {
               filteredSongs = songs.ToList();
            }

            foreach (var song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
