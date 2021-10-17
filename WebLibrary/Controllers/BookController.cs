using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Models;
using WebLibrary.ViewModels;

namespace WebLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookrepository;
        private readonly IPlacement _placementRepository;

        public BookController(IBookRepository bookrepository, IPlacement placementRepository) 
        {
            _bookrepository = bookrepository;
            _placementRepository = placementRepository;
        }

        // Returning a view
        public ViewResult ListOfBooks() 
        {
            BooksListViewModel bookListViewModel = new BooksListViewModel();
            bookListViewModel.Books = _bookrepository.AllBooks;

            bookListViewModel.currentGenre = Genre.Fantasy;
            return View(bookListViewModel);
        }
   
    }
}
