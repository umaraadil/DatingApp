using System.Collections.Generic;
using API.Helpers;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        //Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);          
    }
}