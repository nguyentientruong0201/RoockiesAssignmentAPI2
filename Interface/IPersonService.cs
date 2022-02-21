using APIAssignment1.DTO;

namespace APIAssignment1.Interface
{
    public interface IPersonService
    {
        void AddTask(PersonDTO task);

        public void Initialized() {
            
        }
    }
}