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
        public Video Create(Video video)
        {
            Video newVideo;
            FakeDB.videos.Add(newVideo = new Video()
            {
                Name = video.Name,
                Id = FakeDB.Id++
            });
            return newVideo;
        }

        public Video Delete(int Id)
        {
            var vid = get(Id);
            FakeDB.videos.Remove(vid);
            return vid;
        }

        public Video get(int Id)
        {
            return FakeDB.videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
            return new List<Video>(FakeDB.videos);
        }

        public Video Update(Video video)
        {
            var videoFromDb = get(video.Id);
            if (videoFromDb == null)
            {
                throw new InvalidOperationException("Video not found");
            }
            videoFromDb.Name = video.Name;
            return videoFromDb;
        }
    }
}
