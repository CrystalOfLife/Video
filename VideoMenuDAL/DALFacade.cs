using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuDAL.Repository;

namespace VideoMenuDAL
{
    public class DALFacade
    {
        public IVideoRepository videoRepository
        {
            get { return new VideoRepositoryFakeDB(); }
        }
    }
}
