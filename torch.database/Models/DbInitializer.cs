using System;
using System.Linq;

namespace torch.database.Models
{
    public static class DbInitializer
    {
        public static void Initialize (TorchContext context)
        {
            context.Database.EnsureCreated();

            if (context.States.Any())
            {
                return; //states table already has data don't need to do anything
            }

            State[] states = new State[]
            {
                new State { code="AL", name="Alabama" },
                new State { code="AK", name="Alaska" },
                new State { code="AS", name="American Samoa" },
                new State { code="AZ", name="Arizona" },
                new State { code="AR", name="Arkansas" },
                new State { code="CA", name="California" },
                new State { code="CO", name="Colorado" },
                new State { code="CT", name="Connecticut" },
                new State { code="DE", name="Delaware" },
                new State { code="DC", name="District of Columbia" },
                new State { code="FM", name="Federated States of Micronesia" },
                new State { code="FL", name="Florida" },
                new State { code="GA", name="Georgia" },
                new State { code="GU", name="Guam" },
                new State { code="HI", name="Hawaii" },
                new State { code="ID", name="Idaho" },
                new State { code="IL", name="Illinois" },
                new State { code="IN", name="Indiana" },
                new State { code="IA", name="Iowa" },
                new State { code="KS", name="Kansas" },
                new State { code="KY", name="Kentucky" },
                new State { code="LA", name="Louisiana" },
                new State { code="ME", name="Maine" },
                new State { code="MH", name="Marshall Islands" },
                new State { code="MD", name="Maryland" },
                new State { code="MA", name="Massachusetts" },
                new State { code="MI", name="Michigan" },
                new State { code="MN", name="Minnesota" },
                new State { code="MS", name="Mississippi" },
                new State { code="MO", name="Missouri" },
                new State { code="MT", name="Montana" },
                new State { code="NE", name="Nebraska" },
                new State { code="NV", name="Nevada" },
                new State { code="NH", name="New Hampshire" },
                new State { code="NJ", name="New Jersey" },
                new State { code="NM", name="New Mexico" },
                new State { code="NY", name="New York" },
                new State { code="NC", name="North Carolina" },
                new State { code="ND", name="North Dakota" },
                new State { code="MP", name="Northern Mariana Islands" },
                new State { code="OH", name="Ohio" },
                new State { code="OK", name="Oklahoma" },
                new State { code="OR", name="Oregon" },
                new State { code="PW", name="Palau" },
                new State { code="PA", name="Pennsylvania" },
                new State { code="PR", name="Puerto Rico" },
                new State { code="RI", name="Rhode Island" },
                new State { code="SC", name="South Carolina" },
                new State { code="SD", name="South Dakota" },
                new State { code="TN", name="Tennessee" },
                new State { code="TX", name="Texas" },
                new State { code="UT", name="Utah" },
                new State { code="VT", name="Vermont" },
                new State { code="VI", name="Virgin Islands" },
                new State { code="VA", name="Virginia" },
                new State { code="WA", name="Washington" },
                new State { code="WV", name="West Virginia" },
                new State { code="WI", name="Wisconsin" },
                new State { code="WY", name="Wyoming" }
            };

            foreach (State state in states)
            {
                context.States.Add(state);
            }
            try
            {
                context.SaveChanges();
            }
            catch(Exception exception)
            {
                throw;
            }

        }
    }
}
