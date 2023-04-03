using System;
using System.ComponentModel.DataAnnotations;

namespace Cet322BookStoreHomework2
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }


        public int PublisherId { get; set; } //ıd pk diye var

        public virtual Publisher? Publisher { get; set; } //innerjoin yerine



        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }


    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual List<Book>? Books { get; set; }



    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual List<Book>? Books { get; set; }

    }

   // Book books1 = new Book()
    //{
     //   Id = 1,
    //    Name = "Kürk Mantolu Madonna",
    //    Price = 100,
    //    PageCount= 200,
   //     PublishDate = new DateTime(1943),
   //     PublisherId = 1,
        
  //  };
   // db.Cet322BookStoreHomework2.Add(books1);
   // db.SaveChanges();

}