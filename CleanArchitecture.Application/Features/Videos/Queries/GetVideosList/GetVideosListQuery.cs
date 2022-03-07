using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Videos.Queries.GetVideosList
{
    public class GetVideosListQuery : IRequest<List<VideosVm>>
    {
        public string Username { get; set; } = string.Empty;

        public GetVideosListQuery(string? username)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }
    }
}
