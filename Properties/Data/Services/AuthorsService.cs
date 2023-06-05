using SimpleServer.Data;

public class AuthorsService
{
}

public async Task<Author>AddAuthor(Author author)
{
    DataSource.GetInstance()._authors.Add(author);
    return await Task.FromResult(author);
}

public async Task<Author> GetAuthor(int id)
{
    var result = DataSource.GetInstance()._authors.Find(a => Id == id);
    return await Task.FromResult(result);
}

public async Task<List<Author>> GetAuthors()
{
    return await Task.FromResult(DataSource.GetInstance()._authors);
}

public async Task<Author?> UpdateAuthor(Author newAuthor)
{
    var author = DataSource.GetInstance()._authors.FirstOrDefault(au => au.Id == newAuthor.Id);
    if (author != null)
    {
        author.Fullname = newAuthor.Fullname;
        author.Position = newAuthor.Position;
        author.Grade = newAuthor.Grade;
        return author;
    }

    return null;
}

public async Task<bool> DeleteAuthor(int id)
{
    var author = DataSource.GetInstance()._authors.FirstOrDefault(a => a, Id == id);
    if (author != null)
    {
        _authors.Remove(author);
        return true;
    }

    return false;
}