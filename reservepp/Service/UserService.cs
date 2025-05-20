using reservepp.DTO;
using System.Collections.Generic;
using System.Linq;

namespace reservepp
{
    public class UserService
    {
        private readonly IUserRepository<DTO.UserEntity> _repository;
        private readonly OrderService _orderService;

        public UserService(IUserRepository<DTO.UserEntity> repository, OrderService orderService)
        {
            _repository = repository;
            _orderService = orderService;
        }

        public IEnumerable<DTO.UserEntity> GetAllUsers()
        {
            var userEntities = _repository.GetAll();
            return userEntities.Select(e => MapEntityToUser(e));
        }

        public DTO.UserEntity GetById(int id)
        {
            var entity = _repository.GetById(id);
            return entity != null ? MapEntityToUser(entity) : null;
        }

        public void AddUser(DTO.UserEntity user)
        {
            var entity = MapUserToEntity(user);
            _repository.Add(entity);
        }

        public void UpdateUser(DTO.UserEntity user)
        {
            var entity = MapUserToEntity(user);
            _repository.Update(entity);
        }

        public void DeleteUser(int id)
        {
            _repository.Delete(id);
        }

        private DTO.UserEntity MapEntityToUser(DTO.UserEntity entity)
        {
            if (entity.Role == "Officer")
            {
                return new Officer(
                    entity.FirstName, entity.LastName, entity.Age, entity.DocID,
                    entity.MedicalExaminationResult, entity.HasDeferment, entity.City,
                    entity.HashedPassword, entity.ArmyUnit, this, _orderService);
            }
            else if (entity.Role == "Conscript")
            {
                return new Conscript(
                    entity.FirstName, entity.LastName, entity.Age, entity.DocID,
                    entity.MedicalExaminationResult, entity.HasDeferment, entity.City,
                    entity.HashedPassword, entity.ArmyUnit, this, _orderService);
            }
            else if (entity.Role == "TCKEmployee")
            {
                return new TCKEmployee(
                    entity.FirstName, entity.LastName, entity.Age, entity.DocID,
                    entity.MedicalExaminationResult, entity.HasDeferment, entity.City,
                    entity.HashedPassword, entity.ArmyUnit, this, _orderService);
            }
            else
            {
                return null;
            }
        }

        private DTO.UserEntity MapUserToEntity(DTO.UserEntity user)
        {
            string role;
            if (user is Officer)
                role = "Officer";
            else if (user is Conscript)
                role = "Conscript";
            else if (user is TCKEmployee)
                role = "TCKEmployee";
            else
                role = "Unknown";

            return new DTO.UserEntity
            {
                DocID = user.DocID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Age = user.Age,
                MedicalExaminationResult = user.MedicalExaminationResult,
                HasDeferment = user.HasDeferment,
                City = user.City,
                HashedPassword = user.HashedPassword,
                ArmyUnit = user.ArmyUnit,
                Role = role
            };
        }
    }

}