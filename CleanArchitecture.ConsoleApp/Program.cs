
using CleanArchitecture.Data;
using CleanArchitecture.Domain;

StreamerDbContext dbContext = new();

Streamer streamer = new()
{
    Nombre = "Amazon Prime",
    Url = "https://netflix.com"
};

dbContext!.Streamers!.Add(streamer);

await dbContext.SaveChangesAsync();

var movies = new List<Video>
{
    new Video { Nombre = "Madmax", StreamerId = streamer.Id},
    new Video { Nombre = "Batman", StreamerId = streamer.Id},
    new Video { Nombre = "Crepusculo", StreamerId = streamer.Id},
    new Video { Nombre = "Marvel", StreamerId = streamer.Id}
};


await dbContext!.Videos!.AddRangeAsync(movies);

await dbContext.SaveChangesAsync();