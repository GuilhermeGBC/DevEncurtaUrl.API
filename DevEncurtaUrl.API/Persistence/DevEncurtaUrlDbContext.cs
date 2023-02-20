using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEncurtaUrl.API.Persistence
{
    public class DevEncurtaUrlDbContext
    {
        private int _currentIndex = 1;

        public DevEncurtaUrlDbContext()
        {
            Links = new List<Entities.ShortenedCustomLink>();
        }
        //Lista de links encurtados
        public List<Entities.ShortenedCustomLink> Links { get; set; }

        //Banco em memória
        public void Add(Entities.ShortenedCustomLink link)
        {
            link.Id = _currentIndex;
            _currentIndex++;

            Links.Add(link);
        }
    }
}
