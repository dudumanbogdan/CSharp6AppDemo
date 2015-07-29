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

            #region Ex2
            FullName = $"{firstName} {lastName}";
            #endregion
        }

        // ex.3
        #region Ex3
        private void ValidateParam(string paramName)
        {
            if (string.IsNullOrEmpty(paramName))
            {
                Console.WriteLine($"The parameter {paramName} is null or empty at {DateTime.Now:dd-MMM-yyyy}");
            }
        }
        #endregion
    }
}
