using System;

namespace ChallengeBackEnd
{
    public class DataModel
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Participation{ get; set; }
    }
}
