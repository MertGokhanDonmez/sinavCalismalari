using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class noteMan
    {
        Repository<Note> noteRepo = new Repository<Note>();

        public List<Note> GetAll()
        {
            return noteRepo.List();
        }

    }
}
