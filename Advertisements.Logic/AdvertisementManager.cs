using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
{
    public class AdvertisementManager
    {
        private List<Advertisement> Advertisements;
        private int currentId;

        public AdvertisementManager()
        {
            Advertisements = new List<Advertisement>();
            currentId = 100;
        }

        public List<Advertisement> GetAll()
        {
            return Advertisements;
        }

        public Advertisement Get(int id)
        {
            return Advertisements.Find(a => a.Id == id);
        }

        public Advertisement Create(Advertisement ad)
        {
            ad.Id = currentId;
            Advertisements.Add(ad);
            currentId++;

            return ad;
        }

        public void Delete(int id)
        {
            Advertisement ad = Advertisements.Find(a => a.Id == id);
            Advertisements.Remove(ad);
        }

        public void Seed()
        {
            Advertisements.Add(new Advertisement()
            {
                Id = 1,
                Title = "Advertisement 1",
                Price = 10,
                Photo = "Photo 1",
                Location = "Location 1",
                Time = new DateTime(2001, 1, 1),
                Phone = "Phone 1",
                Email = "Email 1",
                Description = "Description 1",
                CategoryId= 2
            });
            Advertisements.Add(new Advertisement()
            {
                Id = 2,
                Title = "Advertisement 2",
                Price = 20,
                Photo = "Photo 2",
                Location = "Location 2",
                Time = new DateTime(2002, 2, 2),
                Phone = "Phone 2",
                Email = "Email 2",
                Description = "Description 2",
                CategoryId = 2
            });
        }
    }
}
