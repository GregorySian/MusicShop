using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Interfaces;
using MusicHub.Models;
using MusicHub.ViewModels;

namespace MusicHub.Controllers
{
    public class ProductController : Controller
    {
        private IAlbumRepository _repository;
        private Genre genre;
        public int PageSize = 6;

        public ProductController(IAlbumRepository repo)
        {
            _repository = repo;
        }
        public IActionResult Index(int productPage = 1) =>
            View(new AlbumsListViewModel {
                Albums = _repository.Albums.Where(a =>  genre == null || a.Genre == genre.Name ).OrderBy(a => a.Id).Skip((productPage - 1) * PageSize).Take(PageSize),
                PaginationInfo = new PaginationInfoViewModel
                {
                    ItemsPerPage = PageSize,
                    CurrentPage = productPage,
                    TotalItems = _repository.Albums.Count(),
                },
                CurrentGenre = genre.Name
            });
        
    }
}
