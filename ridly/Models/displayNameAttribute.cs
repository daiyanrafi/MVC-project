namespace ridly.Models
{
    internal class displayNameAttribute : Attribute
    {
        private string v;

        public displayNameAttribute(string v)
        {
            this.v = v;
        }
    }
}