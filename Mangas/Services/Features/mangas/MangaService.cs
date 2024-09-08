using Mangas.Domain.Entities;

namespace Mangas.Services.Features.mangas;

public class MangaService
{
    private readonly List<Manga> _mangas1 = new();

    public IEnumerable<Manga> GetAll()
    {
        return _mangas1;
    }

    public Manga GetById(int id)
    {
        return _mangas1.FirstOrDefault(manga => manga.Id == id);
    }

    public void Add(Manga manga)
    {
        _mangas1.Add(manga);
    }

    public void Update(Manga mangaToUpdate)
    {
        var manga = GetById(mangaToUpdate.Id);
        if(manga != null)
        {
            _mangas1.Remove(manga);
            _mangas1.Add(mangaToUpdate);
        }
    }

    public void Delete(int id)
    {
        var manga = GetById(id);

        if(manga != null )
        _mangas1.Remove(manga);
    }
    
}