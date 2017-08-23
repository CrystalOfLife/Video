using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoMenuDAL;
using VideoMenuEntity;

namespace VideoMenuBLL.Services
{
    class VideoService : IVideoService
    {
        IVideoRepository repo;

        public VideoService(IVideoRepository repo)
        {
            this.repo = repo;
        }

        public Video Create(Video video)
        {
            return repo.Create(video);
        }

        public Video Delete(int Id)
        {
            return repo.Delete(Id);
        }

        public Video Get(int Id)
        {
            return repo.Get(Id);
        }

        public List<Video> GetAll()
        {
            return repo.GetAll();
        }

        public Video Update(Video video)
        {
            var videoFromDb = Get(video.Id);
            if (videoFromDb == null)
            {
                throw new InvalidOperationException("Video not found");
            }
            videoFromDb.Name = video.Name;
            return videoFromDb;
        }
    }
}
