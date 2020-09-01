using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicHub.Models;
using MusicHub.Interfaces;

namespace MusicHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly ILogger<HomeController> _logger;
        public int PageSize = 3;

        public HomeController(ILogger<HomeController> logger, IAlbumRepository albumRepository)
        {
            _logger = logger;
            _albumRepository = albumRepository;
        }

        public ViewResult Index()
        {

            var albums = _albumRepository.Albums;

            return View(albums);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> List(int pageNumber = 1)
        {
            return View(await PaginatedList<Album>.CreateAsync(_albumRepository.Albums, pageNumber, 3));
        }
    }
}


        //    => View(new AlbumsListViewModel
        //    {
        //        Albums = _albumRepository.Albums
        //            .OrderBy(a => a.Id)
        //            .Skip((pageIndex - 1) * PageSize)
        //            .Take(PageSize),
        //         PaginationInfo = new PaginationInfoViewModel()
        //        {
        //            CurrentPage = pageIndex,
        //            ItemsPerPage = itemsPage,
        //            TotalItems = totalItems
        //        }
        //    });
        //}

    
