namespace DecoretePattern.Demo
{
    public class Finery:Person
    {
        private Person _person;

        public void Decorate(Person person)
        {
            this._person = person;
        }

        public override void Show()
        {
            _person?.Show();;
        }
    }
}