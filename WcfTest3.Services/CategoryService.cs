using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Core;
using WcfTest3.Core.WcfContracts;
using WcfTest3.Core.WcfServices;
using WcfTest3.Data;
using WcfTest3.DataAccess;

namespace WcfTest3.Services
{
    public class CategoryService : ICategoryService
    {
        WcfTest3Entities db = new WcfTest3Entities();
        private readonly RepositoryBase<Category> _repository;
        private readonly RepositoryBase<Post> _postRepository;

        public CategoryService()
        {
           _repository = new RepositoryBase<Category>(db);
           _postRepository = new RepositoryBase<Post>(db);
        }

        public CategoryContract Create(CategoryContract category)
        {
            _repository.Insert(new Category { Name = category.Name, Description = category.Description });
            _repository.SaveChanges();

            var added = _repository.GetFirst(c => c.Name == category.Name);
            category.Id = added.Id;

            return category;
        }

        public void Delete(int Id)
        {
            var toDelete = _repository.GetSingle(Id);
            if(toDelete != null)
            {
                _repository.Delete(toDelete);
            }
            _repository.SaveChanges();
        }

        public CategoryContract Get(int Id)
        {
            var category = _repository.GetSingle(Id);
            return new CategoryContract { Id = category.Id, Description = category.Description, Name = category.Name};
        }

        public IEnumerable<CategoryContract> GetAll()
        {
            var categories = _repository.GetAll();
            var dto = new List<CategoryContract>();

            foreach(var category in categories)
            {
                var c = new CategoryContract { Id = category.Id, Name = category.Name, Description = category.Description, Posts = new Collection<PostContract>() };
                dto.Add(c);
            }

            return dto;
        }

        public CategoryContract Update(CategoryContract category)
        {
            var entity = _repository.GetSingle(category.Id);

            entity.Name = category.Name;
            entity.Description = category.Description;

            _repository.Update(entity);
            _repository.SaveChanges();

            return category;
        }

        public IEnumerable<PostContract> GetCategoryPosts(string Id)
        {
            if (Int32.TryParse(Id, out int categoryId))
            {
            }
            else
            {
                categoryId = 1;
            }

            var posts = _postRepository.Get(p => p.CategoryId == categoryId);
            var dto = new List<PostContract>();

            foreach (var post in posts)
            {
                var category = _repository.GetSingle(post.CategoryId);
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
                dto.Add(p);
            }

            return dto;
        }
    }
}
