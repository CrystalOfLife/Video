﻿using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuEntity;

namespace VideoMenuDAL
{
    public interface IVideoRepository
    {
        Video Create(Video video);

        List<Video> GetAll();
        Video Get(int Id);

        Video Delete(int Id);
    }
}
