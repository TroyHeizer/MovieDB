namespace MovieDB.Pages

{
    public partial class Index
    {
        public bool ShowCreate { get; set; }
    }
    protected override async Task OnInitializedAsync()
    {
        ShowCreate = false;
    }

    private MovieDataContext? _context;
    public Movie? New { get; Movieset; }

    public void ShowCreateForm()
    {
        NewMovie = new Movie();
        ShowCreate = true;
    }
    public async Task CreateNewMovie()
    { _context ??= await MovieDataContextFactory.CreateDbContextAsync();

        if (NewMovie is not null)
        {
            _context?.Movies.Add(NewMovie);
            _context?.SaveChangesAsync();
        }
        ShowCreate = false;
    }
}


