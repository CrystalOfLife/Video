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
        DALFacade facade;

        public VideoService(DALFacade facade)
        {
            this.facade = facade;
        }

        public Video Create(Video video)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newVideo = uow.VideoRepository.Create(video);
                uow.Complete();
                return newVideo;
            }
        }

        public Video Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newVideo = uow.VideoRepository.Delete(Id);
                uow.Complete();
                return newVideo;
            }
        }

        public Video Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.VideoRepository.Get(Id);
            }
        }

        public List<Video> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.VideoRepository.GetAll();
            }
        }

        public Video Update(Video video)
        {
            using (var uow = facade.UnitOfWork)
            {
                var videoFromDb = uow.VideoRepository.Get(video.Id);
                if (videoFromDb == null)
                {
                    throw new InvalidOperationException("Video not found");
                }
                videoFromDb.Name = video.Name;
                uow.Complete();
                return videoFromDb;
            }
        }
    }
}
