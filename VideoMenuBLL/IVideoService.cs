using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuEntity;

namespace VideoMenuBLL
{
    public interface IVideoService
    {
        Video Create(Video video);

        List<Video> GetAll();
        Video get(int Id);

        Video Update(Video video);

        Video Delete(int Id);
    }
}
