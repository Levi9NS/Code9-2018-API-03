﻿using Code9Insta.API.Core.DTO;
using Code9Insta.API.Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace Code9Insta.API.Infrastructure.Interfaces
{
    public interface IDataRepository
    {
        IEnumerable<Post> GetPosts(string searchString);
        IEnumerable<Post> GetPage(int pageNumber, int pageSize, string searchString);
        bool UserExists(Guid userId);
        bool PostExists(Guid userId);
        void CreatePost(Guid userId, CreatePostDto post);

        bool Save();
        Post GetPostForUser(Guid userId, Guid id);
        IEnumerable<Post> GetPostsForUser(Guid userId);
        Post GetPostById(Guid id);
    }
}
