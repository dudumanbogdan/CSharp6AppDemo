using System;

namespace CSharp6App2.StringInterpol
{
    public class Person
    {
        #region Properties
        public int Age { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; private set; }
        #endregion

        public Person(string firstName, string lastName)
        {
            ValidateParam(firstName);
            ValidateParam(lastName);

            FirstName = firstName;
            LastName = lastName;

            // ex.2
            FullName = $"{firstName} {lastName}";
        }

        // ex.3
        private void ValidateParam(string paramName)
        {
            if (string.IsNullOrEmpty(paramName))
            {
                //throw new ArgumentNullException($"The property {name} is null or empty.", nameof(name));
                Console.WriteLine($"The property {paramName} is null or empty.");

            }
        }
    }
}
