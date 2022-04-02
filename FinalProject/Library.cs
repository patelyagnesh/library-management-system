using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    static class Library
    {
        public static List<LibraryMember> allMembers = new List<LibraryMember>()
        {
            new LibraryMember("Yagnesh"),
            new LibraryMember("Sruthi"),
            new LibraryMember("Harshil"),
            new LibraryMember("Namita"),
            new LibraryMember("Nirav")
        };

        public static List<Media> allMedia = new List<Media>()
        {
            new Book("The Truth", MediaType.Book,640),
            new Book("The Little Prince ", MediaType.Book,430),
            new Book("Think and Grow Rich", MediaType.Book,750),
            new Book("White Tiger", MediaType.Book,1100),
            new Book("The Guide", MediaType.Book,760),
            new Magazine("Family Circle",50, 1234),
            new Magazine("National Geographic",35, 2541),
            new Magazine("Reader’s Digest", 70, 1483),
            new Magazine("Game Informer",140, 3174),
            new Magazine("War and Peace",132, 7546),
            new Movie("The Money Heist",1250),
            new Movie("3 Idiots", 156),
            new Movie("Avengers - End Game", 160),
            new Movie("K.G.F. - Chapter 1", 170),
            new Movie("Fast & Furious 7", 140)
        };
    }
}
