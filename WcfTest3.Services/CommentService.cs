using System;
using System.Collections.Generic;
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
    public class CommentService : ICommentService
    {
        // you can use operation dtos maybe.
        WcfTest3Entities db = new WcfTest3Entities();
        private readonly RepositoryBase<Comment> _repository;
        private readonly RepositoryBase<Post> _postRepository;

        public CommentService()
        {
            _repository = new RepositoryBase<Comment>(db);
            _postRepository = new RepositoryBase<Post>(db);
    }

        public CommentContract Create(CommentContract comment, int postId)
        {
            var p = _postRepository.GetSingle(postId);
            _repository.Insert(new Comment { SentBy = comment.SentBy, SentAt = comment.SentAt, Body = comment.Body, Post = p });
            _repository.SaveChanges();

            var added = _repository.GetSingle(comment.Id);
            comment.Id = added.Id;
            return comment;
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

        public CommentContract Get(int Id)
        {
            var comment = _repository.GetSingle(Id);

            var p = new PostContract
            {
                Id = comment.Post.Id,
                SentBy = comment.Post.SentBy,
                SentAt = comment.Post.SentAt,
                Subject = comment.Post.Subject,
                Body = comment.Post.Body

            };
            return new CommentContract { SentBy = comment.SentBy, SentAt = comment.SentAt, Body = comment.Body, Post = p };
        }

        public IEnumerable<CommentContract> GetAll()
        {
            var comments = _repository.GetAll();
            var dto = new List<CommentContract>();
 
            foreach (var comment in comments)
            {
                var p = new PostContract
                {
                    Id = comment.Post.Id,
                    SentBy = comment.Post.SentBy,
                    SentAt = comment.Post.SentAt,
                    Subject = comment.Post.Subject,
                    Body = comment.Post.Body
                };
                var c = new CommentContract { SentBy = comment.SentBy, SentAt = comment.SentAt, Body = comment.Body, Post = p };
                dto.Add(c);
            }
            return dto;
        }

        public CommentContract Update(CommentContract comment)
        {
            var entity = _repository.GetSingle(comment.Id);
            entity.Body = comment.Body;
            entity.SentAt = comment.SentAt;

            _repository.Update(entity);
            _repository.SaveChanges();


            return new CommentContract { Id = entity.Id, SentBy = entity.SentBy, SentAt = entity.SentAt, Body = entity.Body};
        }
    }
}
