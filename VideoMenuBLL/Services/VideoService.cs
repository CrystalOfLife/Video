using System;
using System.Collections.Generic;
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
            foreach (var video in FakeDB.videos)
            {
                if (video.Id == Id)
                {
                    FakeDB.videos.Remove(video);
                    return video;
                }
            }
            return null;
        }

        public Video get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Video> GetAll()
        {
            throw new NotImplementedException();
        }

        public Video Update(Video video)
        {
            throw new NotImplementedException();
        }


    }
}
