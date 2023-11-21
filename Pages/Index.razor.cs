using MovieDB.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;



namespace MovieDB.Pages

{
    public partial class Index
    {
        public bool ShowCreate { get; set; }
        public bool ShowEdit { get; set; }
        public bool EditRecord { get; set; }
        public int EditingId { get; set; }

        public Movie? MovieToUpdate { get; set; }

        private MovieDataContext? _context;
        public Movie? NewMovie { get; set; }
        public List<Movie> OurMovies { get; set; }


        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowMovies();
        }


        public void ShowCreateForm()
        {
            NewMovie = new Movie();
            ShowCreate = true;
        }
        //This Method adds a New Movie to the Database//
        public async Task CreateNewMovie()
        {
            _context ??= await MovieDataContextFactory.CreateDbContextAsync();

            if (NewMovie is not null)
            {
                _context?.Movies.Add(NewMovie);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            await ShowMovies();
        }
        //This Method Shows the List of our Movies an example of Read//

        public async Task ShowMovies()
        {
            _context ??= await MovieDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                OurMovies = await _context.Movies.ToListAsync();
            }


        }

        //This method allows us to update our oMvie an example of update//
        //------------------ Update! ----------------///

        public async Task ShowEditForm(Movie ourMovie)
        {

            _context ??= await MovieDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                MovieToUpdate = _context.Movies.FirstOrDefault(x => x.Id == ourMovie.Id);
                ShowEdit = true;
                EditingId = ourMovie.Id;
            }
        }

        public async Task UpdateMovie()
        {
            _context ??= await MovieDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (MovieToUpdate is not null) _context.Movies.Update(MovieToUpdate);
                await _context.SaveChangesAsync();
            }
            ShowEdit = false;
        }

        //This is our delete method//
        public async Task DeleteMovie(Movie ourMovie)
        {
            _context ??= await MovieDataContextFactory.CreateDbContextAsync();
            if (_context is not null)
            {
                if (ourMovie is not null) _context.Movies.Remove(ourMovie);
                await _context.SaveChangesAsync();
            }
            await ShowMovies();

        }
    }
}