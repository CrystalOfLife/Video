using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuDAL.Repository;

namespace VideoMenuDAL
{
    public class DALFacade
    {
        public IVideoRepository VideoRepository
        {
            get
            {
                return new VideoRepositoryEFMemory(new Context.InMemoryContext());
            }
        }
    }
}
