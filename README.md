# 🎬 FilmBibliotek

A simple movie library app built in C# for a school project. Basically a digital way to keep track of your movie collection!

This is "Grupp 2's" updated version of our class project.

## What is this?

FilmBibliotek is a console app where you can manage your own movie collection. Add movies, delete them, search through your list, sort them however you want — all from a simple menu in the terminal.

## What can it do?

- **Add movies** — Save new movies with title, year, genre, etc.
- **Delete movies** — Remove movies you don't want anymore
- **Search** — Find specific movies in your collection
- **Sort** — Organize movies by different criteria
- **List all movies** — See everything you've saved
- **Persistent storage** — Your movies are saved to a text file, so they stick around

## Tech stuff

- C# / .NET
- Console application
- Text file for storage (`movies.txt`)

## Project files

```
FilmBibliotek/
├── AddMovies.cs      # Adding new movies
├── DeleteMovies.cs   # Removing movies
├── Exit.cs           # Exit handling
├── Movies.cs         # Movie data stuff
├── NyFilm.cs         # New film creation
├── PrintMenu.cs      # Menu display
├── Program.cs        # Main entry point
├── SearchMovie.cs    # Search functionality
├── SortMovies.cs     # Sorting logic
└── movies.txt        # Where movies are stored
```

## How to run it

1. Clone the repo:
```bash
git clone https://github.com/RickardOtv/FilmBibliotek.git
```

2. Open it in Visual Studio (or VS Code with C# extension)

3. Build and run

4. Use the menu to add, delete, search, or sort your movies

5. Everything gets saved to `movies.txt` automatically

## Ideas for future improvements

- Edit existing movies (not just add/delete)
- Switch to JSON or a proper database
- Better search (case-insensitive, partial matches)
- More error handling
- Unit tests

## Made by

**Grupp 2** — School project  
