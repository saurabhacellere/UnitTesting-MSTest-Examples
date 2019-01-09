namespace UnitTesting_MSTest_Examples
{
    /// <summary>
    /// Employee class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>Returns full name</returns>
        public string GetName(string firstName, string lastName)
        {
            return string.Concat(firstName, " ", lastName);
        }        
    }
}
