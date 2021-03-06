﻿using CoreApp.Application.ViewModels;
using CoreApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.Interfaces
{
    public interface IBookService
    {
        Book GetByID(int ID);
        IEnumerable<Book> GetBooks();
        ApiResponseModel Add(Book b);
        ApiResponseModel Update(Book b);
        ApiResponseModel Delete(Book b);
        Book GetByName(string name);
        ApiResponseModel AddCategory(BookCategory b);
        IEnumerable<BookCategory> GetBookCategory();
        BookCategory GetBookCategorybyId(object categoryId);
        ApiResponseModel UpdateCategory(BookCategory b);
        ApiResponseModel DeleteCategory(int Id);
    }
}
