using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity // Bu bizim customer nesnemiz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }


}