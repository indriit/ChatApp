using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain.Rooms
{
    public interface IRoomRepository
    {
        Task<Room?> GetById(long id);
        Task<Room?> GetByIdWithMembers(long id);
        void Add(Room room);
        void Update(Room room);
        void Remove(Room room);
    }
}
