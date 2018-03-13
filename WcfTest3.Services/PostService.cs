using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfTest3.Core;
using WcfTest3.Core.WcfContracts;
using WcfTest3.Core.WcfServices;
using WcfTest3.Data;
using WcfTest3.DataAccess;

namespace WcfTest3.Services
{
    public class PostService : IPostService
    {
        WcfTest3Entities db = new WcfTest3Entities();
        private readonly RepositoryBase<Post> _repository;
        private readonly RepositoryBase<Category> _categoryRepository;

        public PostService()
        {
            _repository = new RepositoryBase<Post>(db);
            _categoryRepository = new RepositoryBase<Category>(db);
        }

        public PostContract Create(PostContract post)
        {
            var category = _categoryRepository.GetSingle(post.Category.Id);
            var p = new Post
            {
                SentBy = post.SentBy,
                SentAt = post.SentAt,
                Subject = post.Subject,
                Category = category,
                Body = post.Body
            };

            var added = _repository.Insert(p);
            _repository.SaveChanges();

            post.Id = added.Id;
            return post;
        }

        public void Delete(int Id)
        {
            var toDelete = _repository.GetSingle(Id);
            if (toDelete != null)
            {
                _repository.Delete(toDelete);
            }
            _repository.SaveChanges();
        }

        public PostContract Get(int Id)
        {
            var post = _repository.GetSingle(Id);
            var category = _categoryRepository.GetSingle(post.CategoryId);
            var categoryContract = new CategoryContract { Id = category.Id, Name = category.Name, Description = category.Description };
            var p = new PostContract
            {
                Id = post.Id,
                SentBy = post.SentBy,
                SentAt = post.SentAt,
                Subject = post.Subject,
                Category = categoryContract,
                Body = post.Body
            };
            return p;
        }

        public IEnumerable<PostContract> GetAll()
        {
            var categories = _repository.GetAll();
            var dto = new List<PostContract>();

            foreach (var post in categories)
            {
                var category = _categoryRepository.GetSingle(post.CategoryId);
                var categoryContract = new CategoryContract { Id = category.Id, Name = category.Name, Description = category.Description };
                var p = new PostContract {
                    Id = post.Id,
                    SentBy = post.SentBy,
                    SentAt = post.SentAt,
                    Subject = post.Subject,
                    Category = categoryContract,
                    Body = post.Body,
                    Comments = new Collection<CommentContract>()};

                dto.Add(p);
            }
            return dto;
        }

        public PostContract Update(PostContract post)
        {
            var entity = _repository.GetSingle(post.Id);
            var category = _categoryRepository.GetSingle(post.Category.Id);

            entity.Body = post.Body;
            entity.Category = category;
            entity.SentAt = post.SentAt;
            entity.SentBy = post.SentBy;
            entity.Subject = post.Subject;

            _repository.Update(entity);
            _repository.SaveChanges();

            return post;
        }
    }
}
